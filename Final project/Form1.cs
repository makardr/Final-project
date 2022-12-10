using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_project
{
    public partial class Form1 : Form
    {
        List<string> players = new List<string>();
        List<string> roles = new List<string>();
        string guaranteedRole;
        List<AssignedRole> assignedRolesList = new List<AssignedRole>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private List<string> GetInput(string input)
        {
            List<string> output = new List<string>();
            string[] splitInput = input.Split(' ');

            foreach (var word in splitInput)
            {
                output.Add(word);
            }

            return output;
        }
        private AssignedRole CreateAssignedRole(string name,string role)
        {
            AssignedRole objAssignedRole = new AssignedRole();
            objAssignedRole.setAssignedName(name);
            objAssignedRole.setAssignedRole(role);
            return objAssignedRole;
        }
        public string PopFromList(List<string> strList)
        {
            Random rnd = new Random();
            int index = rnd.Next(0, strList.Count);
            string value = strList[index];
            strList.RemoveAt(index);
            return value;
        }
        public bool StringExistsInList(string role, List<AssignedRole> rolesList)
        {
            bool exists = false;
            foreach (AssignedRole roleObj in rolesList){ 
                if (roleObj.getAssignedRole()==role)
                {
                    exists = true;
                }
            }
            return exists;
        }


        private void randomizeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                players.Clear();
                roles.Clear();
                assignedRolesList.Clear();

                players = GetInput(namesTextBox.Text);
                roles = GetInput(rolesTextbox.Text);
                guaranteedRole=guaranteedTextBox.Text;

                if (players.Count < roles.Count)
                {
                    foreach (string player in players)
                    {
                        assignedRolesList.Add(CreateAssignedRole(player, PopFromList(roles)));
                    }
                    if (!StringExistsInList(guaranteedRole, assignedRolesList))
                    {
                        Random rnd = new Random();
                        assignedRolesList[rnd.Next(0, assignedRolesList.Count)].setAssignedRole(guaranteedRole);
                    }
                    refreshPanel();
                } else
                {
                    MessageBox.Show("Not enough roles");
                }
            }
            catch
            {
                MessageBox.Show("Wrong input");
            }
        }
        public void refreshPanel()
        {
            panelScreen.Controls.Clear();
            for (int i = 0; i < assignedRolesList.Count; i++)
            {
                if (assignedRolesList[i] != null)
                {
                    Label newLabel = new Label
                    {
                        Text = "Name: " + assignedRolesList[i].getAssignedName() + " Role: " + assignedRolesList[i].getAssignedRole()

                    };
                    panelScreen.Controls.Add(newLabel);
                    newLabel.AutoSize = false;
                    newLabel.Size = new System.Drawing.Size(500, 27);
                    newLabel.Location = new Point(1, i * 25);
                }
            }
        }
    }    
    public class AssignedRole
    {
        private string playerName;
        private string playerRole;
        public void setAssignedName(string name)
        {
            playerName = name;
        }
        public string getAssignedName()
        {
            return playerName;
        }
        public void setAssignedRole(string role)
        {
            playerRole = role;
        }
        public string getAssignedRole()
        {
            return playerRole;
        }
    }
    
}
