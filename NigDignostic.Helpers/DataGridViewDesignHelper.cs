using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NigDignostic.Helpers
{
    public static class DataGridViewDesignHelper
    {
        public static void DesignDataGridView(DataGridView dataGridView)
        {
            dataGridView.AllowUserToAddRows = true;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AllowUserToResizeRows = false;
            dataGridView.MultiSelect = false;
            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.EditMode = DataGridViewEditMode.EditOnKeystroke;
            //dataGridView.ShowEditingIcon = false;
            dataGridView.TabIndex = 0;
            dataGridView.RowHeadersWidth = 40;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView.RowHeadersDefaultCellStyle.Padding = new Padding(0, 0, 0, 0);
            dataGridView.ShowEditingIcon = false;
            dataGridView.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
            dataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.RowHeadersDefaultCellStyle.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
            dataGridView.RowHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.RowHeadersDefaultCellStyle.BackColor = Color.Gainsboro;
            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Gainsboro;
            dataGridView.RowHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 223, 0);
            dataGridView.RowHeadersDefaultCellStyle.SelectionForeColor = Color.Black;
            dataGridView.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 223, 0);
            dataGridView.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.Black;
            dataGridView.DefaultCellStyle.BackColor = Color.White;
            dataGridView.DefaultCellStyle.Font = new System.Drawing.Font("Verdana", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            dataGridView.DefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 223, 0);
            dataGridView.DefaultCellStyle.SelectionForeColor = Color.Black;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(199, 200, 201);
            dataGridView.ReadOnly = true;
        }
    }
}
