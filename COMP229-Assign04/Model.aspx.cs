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
            this.filePath = MapPath(_Default.jsonFile);


            var jsonString = File.ReadAllText(filePath);
            //TODO: Get json file contents into string
            //JObject o = JObject.Parse(json);


            this.collection = JsonConvert.DeserializeObject<List<Mini>>(jsonString);
            //var currentModel = from mo in this.collection
            //                select mo.MiniName;
            //// produces a list of employee IDs for all female employees
            //foreach (var item in currentModel)
            //{ 
            // if (item == model_name)
            //    Response.Write(item.Rate + "<br/>");
            //}
            foreach (Mini model in collection)
            {
                if (model.MiniName.Equals(model_name))
                {
                    //creat lable in model page after omitting detailview
                    //assigin value lable by model attributes
                    name.Text = model.MiniName;
                    faction.Text = model.faction;
                    rank.Text = (model.rank).ToString();
                    Base.Text = (model._base).ToString();
                    size.Text = (model.size).ToString();
                    deploymentZone.Text = model.deploymentZone;
                    trait.Text = string.Join(",", model.traits);
                    Type.Text = string.Join(",", model.types);
                    Defensechart.Text = string.Join(",", model.defenseChart);
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
                    model_name = model.imageUrl;
                    break;
                }
            }


        }

        protected void UpdateModel_Click(object sender, EventArgs e)
        {

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


            collection = JsonConvert.DeserializeObject<List<Mini>>(jsonString);
            foreach (Mini model in collection)
            {
                if (model.MiniName.Equals(model_name))
                {
                    collection.Remove(model);
                }
            }
            string json;
            json = JsonConvert.SerializeObject(this.collection);
           // var filePath = MapPath("Assign04.json");
            File.WriteAllText(this.filePath, json);
            Response.Redirect("Default.aspx");
        }
    }
}