namespace InstallerTester.Msi
{
    public class MsiTableProperty
    {
        public string PropertyName { get; private set; }
        public string Value { get; private set; }

        public MsiTableProperty(string propertyName, string value)
        {
            PropertyName = propertyName;
            Value = value;
        }
    }
}