namespace GraphicalMathCalculator
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
        protected override void Dispose( bool disposing )
        {
            if (disposing && ( components != null ))
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radVectorLength = new System.Windows.Forms.RadioButton();
            this.radVectorDotProduct = new System.Windows.Forms.RadioButton();
            this.radVectorCross = new System.Windows.Forms.RadioButton();
            this.radDivide = new System.Windows.Forms.RadioButton();
            this.radMultiply = new System.Windows.Forms.RadioButton();
            this.radSubtract = new System.Windows.Forms.RadioButton();
            this.radAdd = new System.Windows.Forms.RadioButton();
            this.grpValueTypeOne = new System.Windows.Forms.GroupBox();
            this.btnDoOperation = new System.Windows.Forms.Button();
            this.cmbInputOne = new System.Windows.Forms.ComboBox();
            this.cmbInputTwo = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.grpValueTypeOne.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add( this.radVectorLength );
            this.groupBox1.Controls.Add( this.radVectorDotProduct );
            this.groupBox1.Controls.Add( this.radVectorCross );
            this.groupBox1.Controls.Add( this.radDivide );
            this.groupBox1.Controls.Add( this.radMultiply );
            this.groupBox1.Controls.Add( this.radSubtract );
            this.groupBox1.Controls.Add( this.radAdd );
            this.groupBox1.Location = new System.Drawing.Point( 366, 12 );
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size( 138, 332 );
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operation to perform";
            // 
            // radVectorLength
            // 
            this.radVectorLength.AutoSize = true;
            this.radVectorLength.Location = new System.Drawing.Point( 6, 174 );
            this.radVectorLength.Name = "radVectorLength";
            this.radVectorLength.Size = new System.Drawing.Size( 58, 17 );
            this.radVectorLength.TabIndex = 6;
            this.radVectorLength.TabStop = true;
            this.radVectorLength.Text = "Length";
            this.radVectorLength.UseVisualStyleBackColor = true;
            // 
            // radVectorDotProduct
            // 
            this.radVectorDotProduct.AutoSize = true;
            this.radVectorDotProduct.Location = new System.Drawing.Point( 6, 151 );
            this.radVectorDotProduct.Name = "radVectorDotProduct";
            this.radVectorDotProduct.Size = new System.Drawing.Size( 81, 17 );
            this.radVectorDotProduct.TabIndex = 5;
            this.radVectorDotProduct.TabStop = true;
            this.radVectorDotProduct.Text = "Dot product";
            this.radVectorDotProduct.UseVisualStyleBackColor = true;
            // 
            // radVectorCross
            // 
            this.radVectorCross.AutoSize = true;
            this.radVectorCross.Location = new System.Drawing.Point( 6, 128 );
            this.radVectorCross.Name = "radVectorCross";
            this.radVectorCross.Size = new System.Drawing.Size( 90, 17 );
            this.radVectorCross.TabIndex = 4;
            this.radVectorCross.TabStop = true;
            this.radVectorCross.Text = "Cross product";
            this.radVectorCross.UseVisualStyleBackColor = true;
            // 
            // radDivide
            // 
            this.radDivide.AutoSize = true;
            this.radDivide.Location = new System.Drawing.Point( 6, 88 );
            this.radDivide.Name = "radDivide";
            this.radDivide.Size = new System.Drawing.Size( 55, 17 );
            this.radDivide.TabIndex = 3;
            this.radDivide.TabStop = true;
            this.radDivide.Text = "Divide";
            this.radDivide.UseVisualStyleBackColor = true;
            // 
            // radMultiply
            // 
            this.radMultiply.AutoSize = true;
            this.radMultiply.Location = new System.Drawing.Point( 6, 65 );
            this.radMultiply.Name = "radMultiply";
            this.radMultiply.Size = new System.Drawing.Size( 60, 17 );
            this.radMultiply.TabIndex = 2;
            this.radMultiply.TabStop = true;
            this.radMultiply.Text = "Multiply";
            this.radMultiply.UseVisualStyleBackColor = true;
            // 
            // radSubtract
            // 
            this.radSubtract.AutoSize = true;
            this.radSubtract.Location = new System.Drawing.Point( 6, 42 );
            this.radSubtract.Name = "radSubtract";
            this.radSubtract.Size = new System.Drawing.Size( 65, 17 );
            this.radSubtract.TabIndex = 1;
            this.radSubtract.TabStop = true;
            this.radSubtract.Text = "Subtract";
            this.radSubtract.UseVisualStyleBackColor = true;
            // 
            // radAdd
            // 
            this.radAdd.AutoSize = true;
            this.radAdd.Location = new System.Drawing.Point( 6, 19 );
            this.radAdd.Name = "radAdd";
            this.radAdd.Size = new System.Drawing.Size( 44, 17 );
            this.radAdd.TabIndex = 0;
            this.radAdd.TabStop = true;
            this.radAdd.Text = "Add";
            this.radAdd.UseVisualStyleBackColor = true;
            // 
            // grpValueTypeOne
            // 
            this.grpValueTypeOne.Controls.Add( this.cmbInputTwo );
            this.grpValueTypeOne.Controls.Add( this.cmbInputOne );
            this.grpValueTypeOne.Location = new System.Drawing.Point( 12, 12 );
            this.grpValueTypeOne.Name = "grpValueTypeOne";
            this.grpValueTypeOne.Size = new System.Drawing.Size( 161, 145 );
            this.grpValueTypeOne.TabIndex = 1;
            this.grpValueTypeOne.TabStop = false;
            this.grpValueTypeOne.Text = "Type of inputs:";
            // 
            // btnDoOperation
            // 
            this.btnDoOperation.Location = new System.Drawing.Point( 395, 354 );
            this.btnDoOperation.Name = "btnDoOperation";
            this.btnDoOperation.Size = new System.Drawing.Size( 90, 23 );
            this.btnDoOperation.TabIndex = 3;
            this.btnDoOperation.Text = "Do operation";
            this.btnDoOperation.UseVisualStyleBackColor = true;
            this.btnDoOperation.Click += new System.EventHandler( this.btnDoOperation_Click );
            // 
            // cmbInputOne
            // 
            this.cmbInputOne.FormattingEnabled = true;
            this.cmbInputOne.Items.AddRange( new object[] {
            "Vector2",
            "Vector3",
            "Vector4",
            "Matrix2",
            "Matrix3",
            "Matrix4"} );
            this.cmbInputOne.Location = new System.Drawing.Point( 6, 28 );
            this.cmbInputOne.Name = "cmbInputOne";
            this.cmbInputOne.Size = new System.Drawing.Size( 121, 21 );
            this.cmbInputOne.TabIndex = 0;
            // 
            // cmbInputTwo
            // 
            this.cmbInputTwo.FormattingEnabled = true;
            this.cmbInputTwo.Items.AddRange( new object[] {
            "Vector2",
            "Vector3",
            "Vector4",
            "Matrix2",
            "Matrix3",
            "Matrix4"} );
            this.cmbInputTwo.Location = new System.Drawing.Point( 6, 97 );
            this.cmbInputTwo.Name = "cmbInputTwo";
            this.cmbInputTwo.Size = new System.Drawing.Size( 121, 21 );
            this.cmbInputTwo.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size( 515, 389 );
            this.Controls.Add( this.btnDoOperation );
            this.Controls.Add( this.grpValueTypeOne );
            this.Controls.Add( this.groupBox1 );
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Graphical Maths Calculator";
            this.groupBox1.ResumeLayout( false );
            this.groupBox1.PerformLayout();
            this.grpValueTypeOne.ResumeLayout( false );
            this.ResumeLayout( false );

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radAdd;
        private System.Windows.Forms.RadioButton radVectorLength;
        private System.Windows.Forms.RadioButton radVectorDotProduct;
        private System.Windows.Forms.RadioButton radVectorCross;
        private System.Windows.Forms.RadioButton radDivide;
        private System.Windows.Forms.RadioButton radMultiply;
        private System.Windows.Forms.RadioButton radSubtract;
        private System.Windows.Forms.GroupBox grpValueTypeOne;
        private System.Windows.Forms.Button btnDoOperation;
        private System.Windows.Forms.ComboBox cmbInputTwo;
        private System.Windows.Forms.ComboBox cmbInputOne;
    }
}

