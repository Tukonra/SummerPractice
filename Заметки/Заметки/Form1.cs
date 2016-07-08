using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Заметки
{
    public partial class Form1 : Form
    {
        List<Notes> notes = new List<Notes>();

        public Form1()
        {
            InitializeComponent();

            notes_list.Rows.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile1 = new SaveFileDialog();
            saveFile1.DefaultExt = "*.txt";
            saveFile1.Filter = "Text files|*.txt";
            if (saveFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
                saveFile1.FileName.Length > 0)
            {
                using (StreamWriter sw = new StreamWriter(saveFile1.FileName, true))
                {
                    sw.WriteLine(richTextBox1.Text);
                    sw.Close();
                }
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            notes[ notes_list.CurrentRow.Index ].text = richTextBox1.Text;
        }

        private void new_note_Click( object sender, EventArgs e )
        {
            notes.Add( new Notes{ text = "" } );

            notes_list.ClearSelection();

            notes_list.Rows.Add( "Безымянная заметка" );
            notes_list.Rows[ notes_list.Rows.Count - 1 ].Selected = true;

            timer_txt.Text = "";

            richTextBox1.Visible = true;
        }

        private void notes_list_SelectionChanged( object sender, EventArgs e )
        {
            richTextBox1.Visible = true;

            richTextBox1.Text = notes[ notes_list.CurrentRow.Index ].text;

            if ( notes[ notes_list.CurrentRow.Index ].timer != -1 )
                timer_txt.Text = notes[ notes_list.CurrentRow.Index ].timer.ToString();
            else
                timer_txt.Text = "";
        }
       
        private void timer_txt_TextChanged( object sender, EventArgs e )
        {
            if( timer_txt.Text != "" && notes_list.CurrentRow != null && notes.ElementAtOrDefault( notes_list.CurrentRow.Index ) != null )
                notes[ notes_list.CurrentRow.Index ].timer = Convert.ToInt32( timer_txt.Text );
        }

        private void timer1_Tick( object sender, EventArgs e )
        {
            for( int i = 0; i < notes.Count; i++ )
            {
                if ( notes.ElementAtOrDefault( i ) == null || notes[ i ].timer == -1 )
                    continue;

                notes[ i ].timer -= 1;

                if ( notes[ i ].timer == 0 )
                    MessageBox.Show( notes_list.Rows[ i ].Cells[ 0 ].Value.ToString(), "Напоминание" );
            }
        }

        private void notes_list_RowsRemoved( object sender, DataGridViewRowsRemovedEventArgs e )
        {
            notes[ e.RowIndex ] = null;
        }
    }

    public class Notes
    {
        public string text;
        public int timer = -1;
    }
}
