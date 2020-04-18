namespace BFS_Algorithm
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNodesEdges = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbNodesAndEdgesForQueries = new System.Windows.Forms.ListBox();
            this.btnAddNodesEdges = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtVerticesForNodesEdges = new System.Windows.Forms.TextBox();
            this.btnAddVertices = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lbVerticesNodesEdges = new System.Windows.Forms.ListBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.bgBFS = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.btnClearSelectionVertice = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtVerticeValue = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtSourceNodeForQuery = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Number of Nodes and Edges per Query:";
            // 
            // txtNodesEdges
            // 
            this.txtNodesEdges.Location = new System.Drawing.Point(15, 25);
            this.txtNodesEdges.Name = "txtNodesEdges";
            this.txtNodesEdges.Size = new System.Drawing.Size(441, 20);
            this.txtNodesEdges.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nodes and Edges for Queries:";
            // 
            // lbNodesAndEdgesForQueries
            // 
            this.lbNodesAndEdgesForQueries.FormattingEnabled = true;
            this.lbNodesAndEdgesForQueries.Location = new System.Drawing.Point(15, 135);
            this.lbNodesAndEdgesForQueries.Name = "lbNodesAndEdgesForQueries";
            this.lbNodesAndEdgesForQueries.Size = new System.Drawing.Size(441, 121);
            this.lbNodesAndEdgesForQueries.TabIndex = 5;
            // 
            // btnAddNodesEdges
            // 
            this.btnAddNodesEdges.Location = new System.Drawing.Point(15, 90);
            this.btnAddNodesEdges.Name = "btnAddNodesEdges";
            this.btnAddNodesEdges.Size = new System.Drawing.Size(441, 23);
            this.btnAddNodesEdges.TabIndex = 6;
            this.btnAddNodesEdges.Text = "Add the Nodes and Edges to list";
            this.btnAddNodesEdges.UseVisualStyleBackColor = true;
            this.btnAddNodesEdges.Click += new System.EventHandler(this.BtnAddNodesEdges_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(262, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Vertices for the selected query nodes in the list above:";
            // 
            // txtVerticesForNodesEdges
            // 
            this.txtVerticesForNodesEdges.Location = new System.Drawing.Point(15, 275);
            this.txtVerticesForNodesEdges.Name = "txtVerticesForNodesEdges";
            this.txtVerticesForNodesEdges.Size = new System.Drawing.Size(441, 20);
            this.txtVerticesForNodesEdges.TabIndex = 8;
            // 
            // btnAddVertices
            // 
            this.btnAddVertices.Location = new System.Drawing.Point(15, 340);
            this.btnAddVertices.Name = "btnAddVertices";
            this.btnAddVertices.Size = new System.Drawing.Size(259, 23);
            this.btnAddVertices.TabIndex = 9;
            this.btnAddVertices.Text = "Add Vertices for the selected query nodes";
            this.btnAddVertices.UseVisualStyleBackColor = true;
            this.btnAddVertices.Click += new System.EventHandler(this.BtnAddVertices_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 366);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(199, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Vertices for Nodes and Edges of Queries";
            // 
            // lbVerticesNodesEdges
            // 
            this.lbVerticesNodesEdges.FormattingEnabled = true;
            this.lbVerticesNodesEdges.Location = new System.Drawing.Point(15, 382);
            this.lbVerticesNodesEdges.Name = "lbVerticesNodesEdges";
            this.lbVerticesNodesEdges.Size = new System.Drawing.Size(441, 212);
            this.lbVerticesNodesEdges.TabIndex = 11;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(15, 600);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(308, 23);
            this.btnCalculate.TabIndex = 12;
            this.btnCalculate.Text = "Calculate BFS";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(504, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Result:";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(507, 25);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(381, 520);
            this.txtResult.TabIndex = 14;
            // 
            // bgBFS
            // 
            this.bgBFS.WorkerReportsProgress = true;
            this.bgBFS.WorkerSupportsCancellation = true;
            this.bgBFS.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BgBFS_DoWork);
            this.bgBFS.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BgBFS_ProgressChanged);
            this.bgBFS.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BgBFS_RunWorkerCompleted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 655);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Lapsed time:";
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Location = new System.Drawing.Point(85, 655);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(21, 13);
            this.lblTimer.TabIndex = 16;
            this.lblTimer.Text = "0 s";
            // 
            // btnClearSelectionVertice
            // 
            this.btnClearSelectionVertice.Location = new System.Drawing.Point(280, 340);
            this.btnClearSelectionVertice.Name = "btnClearSelectionVertice";
            this.btnClearSelectionVertice.Size = new System.Drawing.Size(176, 23);
            this.btnClearSelectionVertice.TabIndex = 17;
            this.btnClearSelectionVertice.Text = "Clear selected Item and vertices";
            this.btnClearSelectionVertice.UseVisualStyleBackColor = true;
            this.btnClearSelectionVertice.Click += new System.EventHandler(this.BtnClearSelectionVertice_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 298);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Vertices Value:";
            // 
            // txtVerticeValue
            // 
            this.txtVerticeValue.Location = new System.Drawing.Point(15, 314);
            this.txtVerticeValue.Name = "txtVerticeValue";
            this.txtVerticeValue.Size = new System.Drawing.Size(441, 20);
            this.txtVerticeValue.TabIndex = 19;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(15, 629);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(441, 23);
            this.progressBar1.TabIndex = 20;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // txtSourceNodeForQuery
            // 
            this.txtSourceNodeForQuery.Location = new System.Drawing.Point(15, 64);
            this.txtSourceNodeForQuery.Name = "txtSourceNodeForQuery";
            this.txtSourceNodeForQuery.Size = new System.Drawing.Size(441, 20);
            this.txtSourceNodeForQuery.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Source Node";
            // 
            // btnClearAll
            // 
            this.btnClearAll.Location = new System.Drawing.Point(329, 600);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(127, 23);
            this.btnClearAll.TabIndex = 25;
            this.btnClearAll.Text = "Clear All Fields";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.BtnClearAll_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 678);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.txtSourceNodeForQuery);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.txtVerticeValue);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnClearSelectionVertice);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lbVerticesNodesEdges);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnAddVertices);
            this.Controls.Add(this.txtVerticesForNodesEdges);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAddNodesEdges);
            this.Controls.Add(this.lbNodesAndEdgesForQueries);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNodesEdges);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNodesEdges;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbNodesAndEdgesForQueries;
        private System.Windows.Forms.Button btnAddNodesEdges;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtVerticesForNodesEdges;
        private System.Windows.Forms.Button btnAddVertices;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lbVerticesNodesEdges;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtResult;
        private System.ComponentModel.BackgroundWorker bgBFS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Button btnClearSelectionVertice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtVerticeValue;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtSourceNodeForQuery;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnClearAll;
    }
}

