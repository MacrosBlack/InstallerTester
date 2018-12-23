using Microsoft.Deployment.WindowsInstaller;
using System.Collections.Generic;

namespace InstallerTester.Msi
{
    public class MsiTableProperty
    {
        /// <summary>
        /// The property name.
        /// </summary>
        public string PropertyName { get; private set; }

        /// <summary>
        /// the property value.
        /// </summary>
        public string Value { get; private set; }

        /// <summary>
        /// Simple container class.
        /// </summary>
        /// <param name="propertyName"></param>
        /// <param name="value"></param>
        public MsiTableProperty(string propertyName, string value)
        {
            PropertyName = propertyName;
            Value = value;
        }

        /// <summary>
        /// Read all records from the Property table.
        /// </summary>
        /// <param name="databasePath"></param>
        /// <returns>A dictionary of the properties.</returns>
        public static Dictionary<string, MsiTableProperty> GetAllRecords(string databasePath)
        {
            var list = new Dictionary<string, MsiTableProperty>();
            using (var db = new Database(databasePath, DatabaseOpenMode.ReadOnly))
            using (var view = db.OpenView("SELECT * FROM Property"))
            {
                view.Execute();
                while (true)
                {
                    var record = view.Fetch();
                    if (record == null)
                    {
                        break;
                    }

                    var property = record["Property"] as string;
                    var value = record["Value"] as string;
                    list.Add(property, new MsiTableProperty(property, value));
                }
            }

            return list;
        }
    }
}