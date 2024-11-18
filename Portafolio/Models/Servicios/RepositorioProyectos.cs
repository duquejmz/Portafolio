namespace Portafolio.Models.Servicios
{
    public class RepositorioProyectos
    {
        public List<Proyecto> ObtenerProyectos()
        {
            return new List<Proyecto>() {
            new Proyecto
            {
                Titulo = "ApiREST | Control de Productos",
                Descripcion = "Simulación de un aplicativo web para el almacenamiento de productos",
                link = "https://http.cat/status/101",
                ImagenURL = "/imagenes/jiji.jpg"
            },
            new Proyecto
            {
                Titulo = "Tarjeta Pokemon",
                Descripcion = "Simulación de una tarjeta de poderes del juego Pokemon.",
                link = "https://http.cat/status/203",
                ImagenURL = "/imagenes/jiji.jpg"
            },
            new Proyecto
            {
                Titulo = "App Movil Palabras Random",
                Descripcion = "Simulación de un aplicativo movil web para conocer el significado de palabras random",
                link = "https://http.cat/status/400",
                ImagenURL = "/imagenes/jiji.jpg"
            },
            new Proyecto
            {
                Titulo = "App de Consola To-Do List",
                Descripcion = "Simulación de un aplicativo web de una lista de tareas",
                link = "https://http.cat/status/405",
                ImagenURL = "/imagenes/jiji.jpg"
            },
            };

        }
    }
}
