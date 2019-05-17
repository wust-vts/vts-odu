namespace vts_odu
{
    partial class AisList
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.mmsi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.latitude = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.longitude = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.heading = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.speed = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.course = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.mmsi,
            this.name,
            this.latitude,
            this.longitude,
            this.heading,
            this.speed,
            this.course});
            this.listView1.Location = new System.Drawing.Point(13, 82);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(775, 356);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // mmsi
            // 
            this.mmsi.Text = "ID";
            // 
            // name
            // 
            this.name.Text = "名称";
            this.name.Width = 80;
            // 
            // latitude
            // 
            this.latitude.Text = "经度";
            this.latitude.Width = 100;
            // 
            // longitude
            // 
            this.longitude.Text = "纬度";
            this.longitude.Width = 100;
            // 
            // heading
            // 
            this.heading.Text = "船首向";
            this.heading.Width = 80;
            // 
            // speed
            // 
            this.speed.Text = "速度";
            this.speed.Width = 80;
            // 
            // course
            // 
            this.course.Text = "航向";
            this.course.Width = 80;
            // 
            // AisList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView1);
            this.Name = "AisList";
            this.Text = "AIS数据";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader mmsi;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader latitude;
        private System.Windows.Forms.ColumnHeader longitude;
        private System.Windows.Forms.ColumnHeader heading;
        private System.Windows.Forms.ColumnHeader speed;
        private System.Windows.Forms.ColumnHeader course;
    }
}