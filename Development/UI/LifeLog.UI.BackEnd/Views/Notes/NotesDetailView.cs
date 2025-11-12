using DevExpress.XtraEditors;
using LifeLog.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LifeLog.UI.BackEnd.Views.Notes
{
	public partial class NotesDetailView : DevExpress.XtraEditors.XtraUserControl
	{
		public NotesDetailView() => InitializeComponent();

		public void LoadDataToForm(NotesModel note)
		{
			if (note == null)
			{
				note = new NotesModel();
				note.CreatedAt = DateTime.Now;
				note.UpdatedAt = DateTime.Now;
			}

			txtTitle.Text = note.Title;
			//mmoText.Text = note.Text;
			colorEdit.Color = Color.FromArgb(note.Color);
		}
	}
}
