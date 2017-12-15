using COMP229_Assign04.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace COMP229_Assign04
{
    public partial class _Default : Page
    {
        public static string jsonFile = "Ngan.json";
        public static string defaultJsonFile = "Assign04.json";

        private String filePath;

        private List<Mini> collection;
        protected void Page_Load(object sender, EventArgs e)
        {
            this.filePath = MapPath(_Default.jsonFile);
            string jsonString;
            if (!File.Exists(filePath))
            {
                jsonString = File.ReadAllText(MapPath(_Default.defaultJsonFile));
                File.WriteAllText(this.filePath, jsonString);
            } else
            {
                jsonString = File.ReadAllText(filePath);
            }

            this.collection = JsonConvert.DeserializeObject<List<Mini>>(jsonString);
            game.DataSource = collection;
            game.DataBind();      
        }

        protected void addModel_Click(object sender, EventArgs e)
        {
            //String name
           
            
            Mini new_model = new Mini() {
                MiniName = name.Text,
                faction = fraction.Text,
                rank = Convert.ToInt32(rank.Text),
                _base = Convert.ToInt32(Base.Text),
                size = Convert.ToInt32(Size.Text),
                deploymentZone = deploymentzone.Text,
                mobility= Convert.ToInt32(Mobility.Text),
                willpower = Convert.ToInt32(willpower.Text),
                resiliance = Convert.ToInt32(resilliance.Text),
                wounds = Convert.ToInt32(wound.Text)
            };
            String json;
            this.collection.Add(new_model);
            json = JsonConvert.SerializeObject(this.collection);
            
            
           // var filePath = MapPath("Assign04.json");
            File.WriteAllText(this.filePath,json);
            Response.Redirect("Default.aspx");
        }
        protected void SendEmail(object sender, EventArgs e)
        {
            SmtpClient smtpClient = new SmtpClient();
            MailMessage message = new MailMessage();
            try
            {
                // These values should be set by the client.
                MailAddress fromAddress = new MailAddress("from@example.com", "From Me");
                message.Subject = "Testing!";
                message.Body = "This is the body of a sample message";

                // These could be static, or dynamic, depending on situation.
                MailAddress toAddress1 = new MailAddress("to@example.com", "You");
                MailAddress toAddress2 = new MailAddress("cc-comp229f2016@outlook.com", "You");
                message.From = fromAddress;
                message.To.Add(toAddress1);
                message.To.Add(toAddress2);
                smtpClient.Host = "smtp-mail.outlook.com";
                smtpClient.Credentials = new System.Net.NetworkCredential("cc-comp229f2016@outlook.com", "comp229pwd");
                smtpClient.Send(message);
                //statusLabel.Text = "Email sent.";
            }
            catch (Exception ex)
            {
                //statusLabel.Text = "Coudn't send the message!";
            }
        }
    }
}