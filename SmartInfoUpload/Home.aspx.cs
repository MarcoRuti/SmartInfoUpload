using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SmartInfoUpload
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        //STRINGA DOVE SALVARE I DOCUMENTI IN UPLOAD
        public String saveLocation = ConfigurationManager.AppSettings["PATH"].ToString();

        //CONTROLLO UTENTE AUTENTICATO - VISIBILITà HOMEPAGE
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (Session["utenteAutenticato"] == null) {
                Request.Headers.Add("Status Code", "403");
                Response.AddHeader("Status Code", "403");
              
                Page.Visible = false;
                Response.Redirect("Login.aspx");
            }
        }

        protected void SubmitHome_Click(object sender, System.EventArgs e)
        {
            uploadTable upTable = new uploadTable();
            usersTable user     = (usersTable)Session["utenteAutenticato"];

            //Controllo File nullo e notifica
            if (File_UP.PostedFile.FileName == "")
                Response.Write("File non caricato correttamente; Data di caricamento: " + DateTime.Now.ToString("dd/MM/yyyy"));
            else
            {
                //Creazione Directory -- "C:\\Users\\pc\\Desktop\\caricamenti" -- 
                if (!Directory.Exists(saveLocation + "\\" + user.id))
                    Directory.CreateDirectory(saveLocation + "\\" + user.id);
                  
                    

                Response.Write(File_UP.PostedFile.FileName + "; Data di caricamento: " + DateTime.Now.ToString("dd/MM/yyyy"));
                
                File_UP.PostedFile.SaveAs(saveLocation + "\\" + user.id + "\\" + File_UP.PostedFile.FileName);
                
                SmartInfoUploadEntities uploadEntities = new SmartInfoUploadEntities();

                //if(upTable.nome_file == File_UP.PostedFile.FileName)
                //Query per confrontare Nome del file caricato e ID dell'utente che esegue l'upload
                if (uploadEntities.uploadTable.Where((X) =>
                                                        X.nome_file == File_UP.PostedFile.FileName &&
                                                        X.id_cliente == user.id) == null)
                {
                    //Carico dati in upTable
                    upTable.id_cliente = user.id;
                    upTable.nome_file = File_UP.PostedFile.FileName;
                    uploadEntities.uploadTable.Add(upTable);

                }
                else upTable.data_caricamento = DateTime.Now;

                uploadEntities.SaveChanges();

            }
        }

        protected void LogoutHome_Click(object sender, System.EventArgs e)
        {
            Session["utenteAutenticato"] = null;
            Response.Redirect("Home.aspx");
        }
    }
}
