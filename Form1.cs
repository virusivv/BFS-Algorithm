using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BFS_Algorithm
{
    public partial class Form1 : Form
    {
        #region Global Variables
        List<bfsModel> bfsItems;
        List<int[]> distancesList;
        int secondsPassed = 0;
        bool[] visitedNodes;
        int[] distances;
        int testScenario = 4;
        bool debug = false;
        #endregion


        #region Control Methods
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            clearItems();
            if (debug)
            {
                if (testScenario == 1)
                {
                    txtNodesEdges.Text = "4 3";
                    txtSourceNodeForQuery.Text = "1";
                    btnAddNodesEdges.PerformClick();
                    lbNodesAndEdgesForQueries.SetSelected(0, true);
                    txtVerticesForNodesEdges.Text = "1 2";
                    txtVerticeValue.Text = "6";
                    btnAddVertices.PerformClick();
                    txtVerticesForNodesEdges.Text = "1 3";
                    btnAddVertices.PerformClick();
                    txtVerticesForNodesEdges.Text = "3 4";
                    btnAddVertices.PerformClick();
                    btnCalculate.PerformClick();
                }
                else if (testScenario == 2)
                {
                    txtNodesEdges.Text = "8 7";
                    txtSourceNodeForQuery.Text = "1";
                    btnAddNodesEdges.PerformClick();
                    lbNodesAndEdgesForQueries.SetSelected(0, true);
                    txtVerticesForNodesEdges.Text = "1 2";
                    txtVerticeValue.Text = "6";
                    btnAddVertices.PerformClick();
                    txtVerticesForNodesEdges.Text = "1 5";
                    btnAddVertices.PerformClick();
                    txtVerticesForNodesEdges.Text = "2 3";
                    btnAddVertices.PerformClick();
                    txtVerticesForNodesEdges.Text = "2 4";
                    btnAddVertices.PerformClick();
                    txtVerticesForNodesEdges.Text = "5 6";
                    btnAddVertices.PerformClick();
                    txtVerticesForNodesEdges.Text = "5 7";
                    btnAddVertices.PerformClick();
                    txtVerticesForNodesEdges.Text = "7 8";
                    btnAddVertices.PerformClick();

                    btnCalculate.PerformClick();
                }
                else if (testScenario == 3)
                {
                    txtNodesEdges.Text = "6 5";
                    txtSourceNodeForQuery.Text = "3";
                    btnAddNodesEdges.PerformClick();
                    lbNodesAndEdgesForQueries.SetSelected(0, true);
                    txtVerticesForNodesEdges.Text = "3 4";
                    txtVerticeValue.Text = "6";
                    btnAddVertices.PerformClick();
                    txtVerticesForNodesEdges.Text = "3 1";
                    btnAddVertices.PerformClick();
                    txtVerticesForNodesEdges.Text = "4 5";
                    btnAddVertices.PerformClick();
                    txtVerticesForNodesEdges.Text = "1 6";
                    btnAddVertices.PerformClick();
                    txtVerticesForNodesEdges.Text = "6 2";
                    btnAddVertices.PerformClick();
                    btnCalculate.PerformClick();
                }
                else if (testScenario == 4)
                {
                    txtNodesEdges.Text = "4 3";
                    txtSourceNodeForQuery.Text = "1";
                    btnAddNodesEdges.PerformClick();
                    lbNodesAndEdgesForQueries.SetSelected(0, true);
                    txtVerticesForNodesEdges.Text = "1 2";
                    txtVerticeValue.Text = "6";
                    btnAddVertices.PerformClick();
                    txtVerticesForNodesEdges.Text = "1 3";
                    btnAddVertices.PerformClick();
                    txtVerticesForNodesEdges.Text = "3 4";
                    btnAddVertices.PerformClick();


                    txtNodesEdges.Text = "8 7";
                    txtSourceNodeForQuery.Text = "1";
                    btnAddNodesEdges.PerformClick();
                    lbNodesAndEdgesForQueries.SetSelected(1, true);
                    txtVerticesForNodesEdges.Text = "1 2";
                    txtVerticeValue.Text = "6";
                    btnAddVertices.PerformClick();
                    txtVerticesForNodesEdges.Text = "1 5";
                    btnAddVertices.PerformClick();
                    txtVerticesForNodesEdges.Text = "2 3";
                    btnAddVertices.PerformClick();
                    txtVerticesForNodesEdges.Text = "2 4";
                    btnAddVertices.PerformClick();
                    txtVerticesForNodesEdges.Text = "5 6";
                    btnAddVertices.PerformClick();
                    txtVerticesForNodesEdges.Text = "5 7";
                    btnAddVertices.PerformClick();
                    txtVerticesForNodesEdges.Text = "7 8";
                    btnAddVertices.PerformClick();

                    btnCalculate.PerformClick();
                }
            }
        }

        private void BgBFS_DoWork(object sender, DoWorkEventArgs e)
        {
            /*
             1st: go foreach query
             2nd: create an array of nodes from 1 to count
             3rd: create an array for distance from 1 to count with values int.maxvalue
             4th: distance[source] value = 0
             5th: visit neighbors and assign values
             6th: visit each neighbors neighbors and assign values
             * */

            for(int bfsId=0;bfsId<bfsItems.Count;bfsId++)
            {
                bfsModel query = bfsItems[bfsId];
                 visitedNodes = new bool[query.Nodes];
                 distances = new int[query.Nodes];

                for(int i=0; i < query.Nodes; i++)
                {
                    visitedNodes[i] = false;
                    distances[i] = int.MaxValue;
                }

                distances[query.SourceNode-1] = 0;
                int currentNode = query.SourceNode-1;
                getChildrenMarkParent(currentNode, bfsId,query);
                distancesList.Add(distances);
            }
            e.Result = "Success";
        }

        private void BgBFS_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void BgBFS_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Result.ToString() == "Success")
            {
                txtResult.Text = "";
                int queryItem = 0;
                foreach(int[] dist in distancesList)
                {
                    queryItem++;
                    string line = "Query {0}:";
                    txtResult.Text += (txtResult.Text.Trim() != "" ? "\r\n\r\n" : "") + string.Format(line, queryItem);
                    int item = 0;
                    foreach (int distance in dist)
                    {
                        item++;
                        line = "\tNode {0} Distance {1}";
                        txtResult.Text += (txtResult.Text.Trim() != "" ? "\r\n" : "") + string.Format(line, item, distance);
                    }
                }
                txtResult.Select(0, 0);
                MessageBox.Show("Calculation finished successfully.");
            }
            else
            {
                MessageBox.Show("Calculation finished with error. "+e.Result);
            }
            changeEnabledForControls(true);
        }

        private void changeEnabledForControls(bool enabled)
        {
            txtNodesEdges.Enabled = enabled;
            btnAddNodesEdges.Enabled = enabled;
            lbNodesAndEdgesForQueries.Enabled = enabled;
            txtVerticesForNodesEdges.Enabled = enabled;
            btnAddVertices.Enabled = enabled;
            lbVerticesNodesEdges.Enabled = enabled;
            btnCalculate.Enabled = enabled;
        }

        private void BtnAddNodesEdges_Click(object sender, EventArgs e)
        {
            if (txtNodesEdges.Text != "")
            {
                int nodes = Convert.ToInt32(txtNodesEdges.Text.Split(' ')[0].Trim());
                int edges = Convert.ToInt32(txtNodesEdges.Text.Split(' ')[1].Trim());
                bfsModel item = new bfsModel();
                item.QueryId = bfsItems.Count + 1;
                item.Nodes = nodes;
                item.Edges = edges;
                item.SourceNode=Convert.ToInt32(txtSourceNodeForQuery.Text.Trim());
                bfsItems.Add(item);
                lbNodesAndEdgesForQueries.Items.Add(string.Format("Query number {0}: Nodes {1} Edges {2}", item.QueryId, nodes, edges));
            }
            else
            {
                MessageBox.Show("Please write the Nodes and Edges for a query");
            }
        }

        private void BtnAddVertices_Click(object sender, EventArgs e)
        {
            if (lbNodesAndEdgesForQueries.SelectedIndex > -1)
            {
                if (txtVerticesForNodesEdges.Text != "")
                {
                    string selectedItemText = lbNodesAndEdgesForQueries.SelectedItem.ToString().Trim();
                    selectedItemText = selectedItemText.Substring(0, selectedItemText.IndexOf(": ")).Replace("Query number", "").Trim();
                    int selectedQueryId = Convert.ToInt32(selectedItemText);
                    int bfsIdInList = bfsItems.FindIndex(x => x.QueryId == selectedQueryId);

                    int verticeSource = Convert.ToInt32(txtVerticesForNodesEdges.Text.Split(' ')[0].Trim());
                    int verticeDestination = Convert.ToInt32(txtVerticesForNodesEdges.Text.Split(' ')[1].Trim());

                    verticeModel vm = new verticeModel();
                    vm.Source = verticeSource;
                    vm.Destination = verticeDestination;
                    vm.Value = Convert.ToInt32(txtVerticeValue.Text.Trim());
                    bfsItems[bfsIdInList].Vertices.Add(vm);
                    lbVerticesNodesEdges.Items.Add(string.Format("Query number {0}: Vertices source {1} destination {2}", selectedQueryId, verticeSource, verticeDestination));
                }
                else
                {
                    MessageBox.Show("Please write the Vertice source and destination nodes");
                }
            }
            else
            {
                MessageBox.Show("Select a Query from Node and Edge for Queries");
            }
        }

        private void BtnClearSelectionVertice_Click(object sender, EventArgs e)
        {
            lbNodesAndEdgesForQueries.SelectedIndex = -1;
            txtVerticesForNodesEdges.Text = "";
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            if (bfsItems.Count > 0)
            {
                changeEnabledForControls(false);
                bgBFS.RunWorkerAsync();
            }
            else
            {
                MessageBox.Show("You must add at least 1 Query!");
            }
        }

        private void BtnClearAll_Click(object sender, EventArgs e)
        {
            clearItems();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            secondsPassed++;
            TimeSpan t = new TimeSpan(secondsPassed);
            string timerTxt = "{0:D1} s";
            if (t.Minutes > 0)
                timerTxt = "{1:D1} m, " + timerTxt;
            if (t.Hours > 0)
                timerTxt = "{2:D1} m, " + timerTxt;
            lblTimer.Text = string.Format(timerTxt, t.Seconds, t.Minutes, t.Hours);
        }
        #endregion

        #region Custom Methods

        private void clearItems()
        {
            bfsItems = new List<bfsModel>();
            lbNodesAndEdgesForQueries.Items.Clear();
            lbVerticesNodesEdges.Items.Clear();
            txtNodesEdges.Text = "";
            txtSourceNodeForQuery.Text = "";
            txtVerticesForNodesEdges.Text = "";
            txtVerticeValue.Text = "";
            distancesList = new List<int[]>();
        }

        private void getChildrenMarkParent(int currentNode, int bfsId, bfsModel bfsItem)
        {
            List<verticeModel> children = getChildren(bfsId, currentNode);
            verticeModel smallestDist = new verticeModel();
            smallestDist.Value = int.MaxValue;
            for (int childrenId = 0; childrenId < children.Count; childrenId++)
            {
                distances[children[childrenId].Destination - 1] = distances[currentNode] + children[childrenId].Value;
                if ((smallestDist == null || smallestDist.Value > children[childrenId].Value) &&
                    !visitedNodes[children[childrenId].Destination - 1])
                    smallestDist = children[childrenId];
            }
            visitedNodes[currentNode] = true;
            currentNode = getNeighborOrChild(currentNode, bfsItem, visitedNodes, bfsId);
            if (currentNode != -1)
                getChildrenMarkParent(currentNode, bfsId, bfsItem);
            else
            {
                currentNode = smallestDist.Destination - 1;
                if (currentNode != -1)
                    getChildrenMarkParent(currentNode, bfsId, bfsItem);
            }
        }

        private int getNeighborOrChild(int currentNode, bfsModel bfsItem, bool[] visitedNodes, int bfsId)
        {


            List<verticeModel> rt = bfsItem.Vertices.FindAll(x => x.Destination == currentNode + 1 && visitedNodes[x.Source - 1]);
            verticeModel rtv = rt.Min();
            if (rtv == null)
                return -1;
            int sourceId = rtv.Source;

            List<verticeModel> children = getChildren(bfsId, sourceId - 1);
            int smallestDist = int.MaxValue;
            int returnNode = -1;
            for (int i = 0; i < children.Count; i++)
            {
                if (!visitedNodes[children[i].Destination - 1] && children[i].Value < smallestDist)
                {
                    smallestDist = children[i].Value;
                    returnNode = children[i].Destination - 1;
                }
            }
            return returnNode;
        }

        private List<verticeModel> getChildren(int bfsItemId, int node)
        {
            List<int> children = new List<int>();

            bfsModel item = bfsItems[bfsItemId];

            return item.Vertices.FindAll(x => x.Source == node+1);
        }
        #endregion
    }
}
