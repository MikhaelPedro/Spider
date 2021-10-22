namespace Spider.Entidades
{   
    public class DefaultReturnBase
    {
        public string Texto { get; set; }

        public DefaultReturnBase(string texto)
        {
            Texto = texto;
        }

        public string removerAcentos(string texto)
        {
            string comAcentos = "ÄÅÁÂÀÃäáâàãÉÊËÈéêëèÍÎÏÌíîïìÖÓÔÒÕöóôòõÜÚÛüúûùÇç";
            string semAcentos = "AAAAAAaaaaaEEEEeeeeIIIIiiiiOOOOOoooooUUUuuuuCc";

            for (int i = 0; i < comAcentos.Length; i++)
            {
                 texto = texto.Replace(comAcentos[i].ToString(), semAcentos[i].ToString());
            }
            Texto = texto;
            return Texto;
        }
    }
}