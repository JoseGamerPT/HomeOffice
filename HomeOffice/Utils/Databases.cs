using Retail2.Managers;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Retail2.Utils
{
    class Databases
    {
        private static Random r = new Random();

        public static String getCon(int i)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZzxcvbnmalskdjfhgpqowieuryt0123456789";
            return new string(Enumerable.Repeat(chars, i)
              .Select(s => s[r.Next(s.Length)]).ToArray());
        }

        public static DataTable RemoveDuplicateRows(DataTable table, string DistinctColumn)
        {
            try
            {
                ArrayList UniqueRecords = new ArrayList();
                ArrayList DuplicateRecords = new ArrayList();

                // Check if records is already added to UniqueRecords otherwise,
                // Add the records to DuplicateRecords
                foreach (DataRow dRow in table.Rows)
                {
                    if (UniqueRecords.Contains(dRow[DistinctColumn]))
                        DuplicateRecords.Add(dRow);
                    else
                        UniqueRecords.Add(dRow[DistinctColumn]);
                }

                // Remove duplicate rows from DataTable added to DuplicateRecords
                foreach (DataRow dRow in DuplicateRecords)
                {
                    table.Rows.Remove(dRow);
                }

                // Return the clean DataTable which contains unique records.
                return table;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static Size getSize(String str)
        {
            string[] s = str.Split(';');
            int i = Int32.Parse(s[0]);
            int i2 = Int32.Parse(s[1]);
            return new Size(i, i2);
        }

        public static Point getLocation(String str)
        {
            string[] s = str.Split(';');
            int i = Int32.Parse(s[0]);
            int i2 = Int32.Parse(s[1]);
            return new Point(i, i2);
        }

        public static string compactData(DataTable dataTable)
        {
            string data = string.Empty;
            int rowsCount = dataTable.Rows.Count;
            for (int i = 0; i < rowsCount; i++)
            {
                DataRow row = dataTable.Rows[i];
                int columnsCount = dataTable.Columns.Count;
                if (row.RowState != DataRowState.Deleted)
                {
                    for (int j = 0; j < columnsCount; j++)
                    {
                        data += dataTable.Columns[j].ColumnName + "~" + row[j];
                        if (j == columnsCount - 1)
                        {
                            if (i != (rowsCount - 1))
                                data += "$";
                        }
                        else
                            data += "|";
                    }
                }
            }
            return data;
        }

        public static DataTable uncompactTable(string data)
        {
            DataTable dataTable = new DataTable();
            bool columnsAdded = false;
            foreach (string row in data.Split('$'))
            {
                DataRow dataRow = dataTable.NewRow();
                foreach (string cell in row.Split('|'))
                {
                    if (string.IsNullOrEmpty(cell) == false)
                    {
                        string[] keyValue = cell.Split('~');
                        if (!columnsAdded)
                        {
                            DataColumn dataColumn = new DataColumn(keyValue[0]);
                            dataTable.Columns.Add(dataColumn);
                        }
                        dataRow[keyValue[0]] = keyValue[1];
                    }
                }
                columnsAdded = true;
                dataTable.Rows.Add(dataRow);
            }
            return dataTable;
        }

        static Dictionary<String, Image> dic = new Dictionary<string, Image>();

        public static String compactList(List<String> l)
        {
            return String.Join("§", l.ToArray());
        }

        public static List<string> uncompactList(String s)
        {
            if (s != null)
            {
                return s.Split('§').ToList();
            }
            else
            {
                return new List<string>();
            }
        }
    }
}
