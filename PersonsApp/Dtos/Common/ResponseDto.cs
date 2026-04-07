namespace PersonsApp.Dtos.Common
{
    public class ResponseDto<T>
    {
        public int StatusCode {get ; set ;}//Codigo de Respuesta 
        public string Message {get ; set ;}// Mensaje de la respuesta 
        public bool Status {get ; set ; }//Verdadero para respuestas sin errores y si no, falso
        public T Data {get ; set;}
    }
}