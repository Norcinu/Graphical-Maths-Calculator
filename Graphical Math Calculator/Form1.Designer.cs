namespace Graphical_Math_Calculator
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
            this.radAdd = new System.Windows.Forms.RadioButton();
            this.radSubtract = new System.Windows.Forms.RadioButton();
            this.radMultiply = new System.Windows.Forms.RadioButton();
            this.radDivide = new System.Windows.Forms.RadioButton();
            this.grpValueTypeOne = new System.Windows.Forms.GroupBox();
            this.radTypeVector2 = new System.Windows.Forms.RadioButton();
            this.radTypeVector3 = new System.Windows.Forms.RadioButton();
            this.radTypeVector4 = new System.Windows.Forms.RadioButton();
            this.radTypeMatrix2 = new System.Windows.Forms.RadioButton();
            this.radTypeMatrix3 = new System.Windows.Forms.RadioButton();
            this.radTypeMatrix4 = new System.Windows.Forms.RadioButton();
            this.grpValueTypeTwo = new System.Windows.Forms.GroupBox();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.radioButton10 = new System.Windows.Forms.RadioButton();
            this.radioButton11 = new System.Windows.Forms.RadioButton();
            this.radioButton12 = new System.Windows.Forms.RadioButton();
            this.radVectorCross = new System.Windows.Forms.RadioButton();
            this.radVectorDotProduct = new System.Windows.Forms.RadioButton();
            this.radVectorLength = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.grpValueTypeOne.SuspendLayout();
            this.grpValueTypeTwo.SuspendLayout();
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
            // grpValueTypeOne
            // 
            this.grpValueTypeOne.Controls.Add( this.radTypeMatrix4 );
            this.grpValueTypeOne.Controls.Add( this.radTypeMatrix3 );
            this.grpValueTypeOne.Controls.Add( this.radTypeMatrix2 );
            this.grpValueTypeOne.Controls.Add( this.radTypeVector4 );
            this.grpValueTypeOne.Controls.Add( this.radTypeVector3 );
            this.grpValueTypeOne.Controls.Add( this.radTypeVector2 );
            this.grpValueTypeOne.Location = new System.Drawing.Point( 12, 12 );
            this.grpValueTypeOne.Name = "grpValueTypeOne";
            this.grpValueTypeOne.Size = new System.Drawing.Size( 161, 145 );
            this.grpValueTypeOne.TabIndex = 1;
            this.grpValueTypeOne.TabStop = false;
            this.grpValueTypeOne.Text = "Type of input 1:";
            // 
            // radTypeVector2
            // 
            this.radTypeVector2.AutoSize = true;
            this.radTypeVector2.Location = new System.Drawing.Point( 6, 19 );
            this.radTypeVector2.Name = "radTypeVector2";
            this.radTypeVector2.Size = new System.Drawing.Size( 62, 17 );
            this.radTypeVector2.TabIndex = 0;
            this.radTypeVector2.TabStop = true;
            this.radTypeVector2.Text = "Vector2";
            this.radTypeVector2.UseVisualStyleBackColor = true;
            // 
            // radTypeVector3
            // 
            this.radTypeVector3.AutoSize = true;
            this.radTypeVector3.Location = new System.Drawing.Point( 94, 19 );
            this.radTypeVector3.Name = "radTypeVector3";
            this.radTypeVector3.Size = new System.Drawing.Size( 62, 17 );
            this.radTypeVector3.TabIndex = 1;
            this.radTypeVector3.TabStop = true;
            this.radTypeVector3.Text = "Vector3";
            this.radTypeVector3.UseVisualStyleBackColor = true;
            // 
            // radTypeVector4
            // 
            this.radTypeVector4.AutoSize = true;
            this.radTypeVector4.Location = new System.Drawing.Point( 6, 42 );
            this.radTypeVector4.Name = "radTypeVector4";
            this.radTypeVector4.Size = new System.Drawing.Size( 62, 17 );
            this.radTypeVector4.TabIndex = 2;
            this.radTypeVector4.TabStop = true;
            this.radTypeVector4.Text = "Vector4";
            this.radTypeVector4.UseVisualStyleBackColor = true;
            // 
            // radTypeMatrix2
            // 
            this.radTypeMatrix2.AutoSize = true;
            this.radTypeMatrix2.Location = new System.Drawing.Point( 6, 88 );
            this.radTypeMatrix2.Name = "radTypeMatrix2";
            this.radTypeMatrix2.Size = new System.Drawing.Size( 59, 17 );
            this.radTypeMatrix2.TabIndex = 3;
            this.radTypeMatrix2.TabStop = true;
            this.radTypeMatrix2.Text = "Matrix2";
            this.radTypeMatrix2.UseVisualStyleBackColor = true;
            // 
            // radTypeMatrix3
            // 
            this.radTypeMatrix3.AutoSize = true;
            this.radTypeMatrix3.Location = new System.Drawing.Point( 94, 88 );
            this.radTypeMatrix3.Name = "radTypeMatrix3";
            this.radTypeMatrix3.Size = new System.Drawing.Size( 59, 17 );
            this.radTypeMatrix3.TabIndex = 4;
            this.radTypeMatrix3.TabStop = true;
            this.radTypeMatrix3.Text = "Matrix3";
            this.radTypeMatrix3.UseVisualStyleBackColor = true;
            // 
            // radTypeMatrix4
            // 
            this.radTypeMatrix4.AutoSize = true;
            this.radTypeMatrix4.Location = new System.Drawing.Point( 6, 111 );
            this.radTypeMatrix4.Name = "radTypeMatrix4";
            this.radTypeMatrix4.Size = new System.Drawing.Size( 59, 17 );
            this.radTypeMatrix4.TabIndex = 5;
            this.radTypeMatrix4.TabStop = true;
            this.radTypeMatrix4.Text = "Matrix4";
            this.radTypeMatrix4.UseVisualStyleBackColor = true;
            // 
            // grpValueTypeTwo
            // 
            this.grpValueTypeTwo.Controls.Add( this.radioButton7 );
            this.grpValueTypeTwo.Controls.Add( this.radioButton8 );
            this.grpValueTypeTwo.Controls.Add( this.radioButton9 );
            this.grpValueTypeTwo.Controls.Add( this.radioButton10 );
            this.grpValueTypeTwo.Controls.Add( this.radioButton11 );
            this.grpValueTypeTwo.Controls.Add( this.radioButton12 );
            this.grpValueTypeTwo.Location = new System.Drawing.Point( 189, 12 );
            this.grpValueTypeTwo.Name = "grpValueTypeTwo";
            this.grpValueTypeTwo.Size = new System.Drawing.Size( 161, 145 );
            this.grpValueTypeTwo.TabIndex = 2;
            this.grpValueTypeTwo.TabStop = false;
            this.grpValueTypeTwo.Text = "Type of input 1:";
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point( 6, 111 );
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size( 59, 17 );
            this.radioButton7.TabIndex = 5;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "Matrix4";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Location = new System.Drawing.Point( 94, 88 );
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size( 59, 17 );
            this.radioButton8.TabIndex = 4;
            this.radioButton8.TabStop = true;
            this.radioButton8.Text = "Matrix3";
            this.radioButton8.UseVisualStyleBackColor = true;
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.Location = new System.Drawing.Point( 6, 88 );
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size( 59, 17 );
            this.radioButton9.TabIndex = 3;
            this.radioButton9.TabStop = true;
            this.radioButton9.Text = "Matrix2";
            this.radioButton9.UseVisualStyleBackColor = true;
            // 
            // radioButton10
            // 
            this.radioButton10.AutoSize = true;
            this.radioButton10.Location = new System.Drawing.Point( 6, 42 );
            this.radioButton10.Name = "radioButton10";
            this.radioButton10.Size = new System.Drawing.Size( 62, 17 );
            this.radioButton10.TabIndex = 2;
            this.radioButton10.TabStop = true;
            this.radioButton10.Text = "Vector4";
            this.radioButton10.UseVisualStyleBackColor = true;
            // 
            // radioButton11
            // 
            this.radioButton11.AutoSize = true;
            this.radioButton11.Location = new System.Drawing.Point( 94, 19 );
            this.radioButton11.Name = "radioButton11";
            this.radioButton11.Size = new System.Drawing.Size( 62, 17 );
            this.radioButton11.TabIndex = 1;
            this.radioButton11.TabStop = true;
            this.radioButton11.Text = "Vector3";
            this.radioButton11.UseVisualStyleBackColor = true;
            // 
            // radioButton12
            // 
            this.radioButton12.AutoSize = true;
            this.radioButton12.Location = new System.Drawing.Point( 6, 19 );
            this.radioButton12.Name = "radioButton12";
            this.radioButton12.Size = new System.Drawing.Size( 62, 17 );
            this.radioButton12.TabIndex = 0;
            this.radioButton12.TabStop = true;
            this.radioButton12.Text = "Vector2";
            this.radioButton12.UseVisualStyleBackColor = true;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size( 515, 389 );
            this.Controls.Add( this.grpValueTypeTwo );
            this.Controls.Add( this.grpValueTypeOne );
            this.Controls.Add( this.groupBox1 );
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Graphical Maths Calculator";
            this.groupBox1.ResumeLayout( false );
            this.groupBox1.PerformLayout();
            this.grpValueTypeOne.ResumeLayout( false );
            this.grpValueTypeOne.PerformLayout();
            this.grpValueTypeTwo.ResumeLayout( false );
            this.grpValueTypeTwo.PerformLayout();
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
        private System.Windows.Forms.RadioButton radTypeMatrix4;
        private System.Windows.Forms.RadioButton radTypeMatrix3;
        private System.Windows.Forms.RadioButton radTypeMatrix2;
        private System.Windows.Forms.RadioButton radTypeVector4;
        private System.Windows.Forms.RadioButton radTypeVector3;
        private System.Windows.Forms.RadioButton radTypeVector2;
        private System.Windows.Forms.GroupBox grpValueTypeTwo;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.RadioButton radioButton9;
        private System.Windows.Forms.RadioButton radioButton10;
        private System.Windows.Forms.RadioButton radioButton11;
        private System.Windows.Forms.RadioButton radioButton12;
    }
}

