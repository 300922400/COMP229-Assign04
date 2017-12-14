using COMP229_Assign04.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace COMP229_Assign04
{
    public partial class _Default : Page
    {
        private String filePath;
        private List<Mini> collection;
        protected void Page_Load(object sender, EventArgs e)
        {
            this.filePath = MapPath("Assign04.json");

            // DO NOT use local paths. Use relative pathing; ideally to a file in the project.

            //if (File.Exists(filePath))
            //if (false)

            var jsonString = File.ReadAllText(filePath);
                //TODO: Get json file contents into string
               
                 this.collection = JsonConvert.DeserializeObject<List<Mini>>(jsonString);
            //var i = 0;
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
            json = JsonConvert.SerializeObject(this.collection);
            this.collection.Add(new_model);
            
           // var filePath = MapPath("Assign04.json");
            File.WriteAllText(this.filePath,json);
            Response.Redirect("Default.aspx");
        }
    }
}