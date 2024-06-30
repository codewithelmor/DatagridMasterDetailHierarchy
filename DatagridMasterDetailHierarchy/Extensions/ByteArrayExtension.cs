namespace DatagridMasterDetailHierarchy.Extensions
{
    public static class ByteArrayExtension
    {
        public static string ToBase64String(this byte[] byteArrays)
        {
            string base64String = Convert.ToBase64String(byteArrays);
            //string base64String = BitConverter.ToString(byteArrays);
            string dataUri = "data:image/jpeg;base64," + base64String;
            return dataUri;
        }
    }
}
