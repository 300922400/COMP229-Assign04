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
    public partial class Contact : Page
    {
        private string filePath;
        private List<Mini> collection;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                String model_name = Request.QueryString["model"];
                this.filePath = MapPath(_Default.jsonFile);
                string jsonString = File.ReadAllText(filePath);
                //using Linq
                this.collection = JsonConvert.DeserializeObject<List<Mini>>(jsonString);
                Mini currentModel = (from mo in this.collection
                                     where mo.MiniName == model_name
                                     select mo).First();

                nameDisplay.Text = currentModel.MiniName;
                factionDisplay.Text = currentModel.faction;
                rankDisplay.Text = (currentModel.rank).ToString();
                BaseDisplay.Text = (currentModel._base).ToString();
                sizeDisplay.Text = (currentModel.size).ToString();
                deploymentZoneDisplay.Text = currentModel.deploymentZone;
                traitDisplay.Text = currentModel.traits == null ? "" : string.Join(",", currentModel.traits);
                TypeDisplay.Text = currentModel.types == null ? "" : string.Join(",", currentModel.types);
                DefensechartDisplay.Text = currentModel.defenseChart == null ? "" : string.Join(",", currentModel.defenseChart);
                mobilityDisplay.Text = (currentModel.mobility).ToString();
                willpowerDisplay.Text = (currentModel.willpower).ToString();
                resilianceDisplay.Text = (currentModel.resiliance).ToString();
                woundDisplay.Text = (currentModel.wounds).ToString();
            }
        }

        protected void Update_Click(object sender, EventArgs e)
        {
            String model_name = Request.QueryString["model"];
            this.filePath = MapPath(_Default.jsonFile);
            string jsonString = File.ReadAllText(filePath);
            //using Linq
            this.collection = JsonConvert.DeserializeObject<List<Mini>>(jsonString);
            Mini currentModel = (from mo in this.collection
                                 where mo.MiniName == model_name
                                 select mo).First();
            currentModel.MiniName = nameDisplay.Text;
            currentModel.faction = factionDisplay.Text;
            currentModel.rank = Convert.ToInt32(rankDisplay.Text);
            currentModel._base = Convert.ToInt32(BaseDisplay.Text);
            currentModel.size = Convert.ToInt32(sizeDisplay.Text);
            currentModel.deploymentZone = deploymentZoneDisplay.Text;
            currentModel.deploymentZone = TypeDisplay.Text;
            currentModel.mobility = Convert.ToInt32(mobilityDisplay.Text);
            currentModel.willpower = Convert.ToInt32(willpowerDisplay.Text);
            currentModel.resiliance = Convert.ToInt32(resilianceDisplay.Text);
            currentModel.wounds = Convert.ToInt32(woundDisplay.Text);
            string json;
            json = JsonConvert.SerializeObject(this.collection);
            // var filePath = MapPath("Assign04.json");
            File.WriteAllText(this.filePath, json);
            Response.Redirect("Default.aspx");
        }
    }
}