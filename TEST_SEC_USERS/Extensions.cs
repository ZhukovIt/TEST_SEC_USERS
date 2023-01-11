using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace TEST_SEC_USERS.Extensions
{
    public static class Extensions
    {
        public static void StrikeSelectedRowsExtensions(this DataGridViewSelectedRowCollection rows, List<string> removedRows)
        {
            foreach(DataGridViewRow row in rows)
            {
                if (row.DefaultCellStyle.Font == null || !row.DefaultCellStyle.Font.Strikeout)
                {
                    row.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Strikeout, GraphicsUnit.Point, 204);
                    removedRows.Add((string)row.Cells[0].Value);
                }
                else
                {
                    row.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
                    removedRows.Remove(removedRows.Single(delRow => delRow == (string)row.Cells[0].Value));
                }
            }
        }
    }
}
