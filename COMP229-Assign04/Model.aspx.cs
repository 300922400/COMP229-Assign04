using COMP229_Assign04.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace COMP229_Assign04
{
    public partial class About : Page
    {
        private String filePath;
        private List<Mini> collection;
        protected void Page_Load(object sender, EventArgs e)
        {
            
            String model_name = Request.QueryString["model"];
            //this.defaultFilePath = MapPath("Assign04.json");
            if (model_name != null)
            {
                this.filePath = MapPath(_Default.jsonFile);


                var jsonString = File.ReadAllText(filePath);

                this.collection = JsonConvert.DeserializeObject<List<Mini>>(jsonString);

                Mini model = (from mo in this.collection
                              where mo.MiniName == model_name
                              select mo).First();

                name.Text = model.MiniName;
                faction.Text = model.faction;
                rank.Text = (model.rank).ToString();
                Base.Text = (model._base).ToString();
                size.Text = (model.size).ToString();
                deploymentZone.Text = model.deploymentZone;
                trait.Text = model.traits == null ? "" : string.Join(",", model.traits);
                Type.Text = model.types == null ? "" : string.Join(",", model.types);
                Defensechart.Text = model.defenseChart == null ? "" : string.Join(",", model.defenseChart);
                mobility.Text = (model.mobility).ToString();
                willpower.Text = (model.willpower).ToString();
                resiliance.Text = (model.resiliance).ToString();
                wound.Text = (model.wounds).ToString();
                actionGrid.DataSource = model.actions;
                actionGrid.DataBind();
                Grid_special.DataSource = model.specialAbilities;
                Grid_special.DataBind();
                //action.Text = string.Join(",", model.actions);
                //specialAbilities.Text = string.Join(",",model.specialAbilities);
                model_image.ImageUrl = model.imageUrl;
                //model_name = model.imageUrl;
            }
            else
            {
                Response.Redirect("Default.aspx");
            }
    
        }

        protected void UpdateModel_Click(object sender, EventArgs e)
        {
            Response.Redirect("Update.aspx?model=" + Request.QueryString["model"]);
        }

        protected void DeleteModel_Click(object sender, EventArgs e)
        {
            //search then have to serialize again
            String model_name = Request.QueryString["model"];
            //this.defaultFilePath = MapPath("Assign04.json");
            this.filePath = MapPath(_Default.jsonFile);


            var jsonString = File.ReadAllText(filePath);
            //TODO: Get json file contents into string
            //JObject o = JObject.Parse(json);


            this.collection = JsonConvert.DeserializeObject<List<Mini>>(jsonString);
            Mini model = (from mo in this.collection
                          where mo.MiniName == model_name
                          select mo).First();
            this.collection.Remove(model);
            string json;
            json = JsonConvert.SerializeObject(this.collection);
           // var filePath = MapPath("Assign04.json");
            File.WriteAllText(this.filePath, json);
            Response.Redirect("Default.aspx");
        }
    }
}