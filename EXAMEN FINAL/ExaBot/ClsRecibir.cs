using ExaBot.Archivo;
using ExaBot.Conexion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Args;
using Telegram.Bot.Types.Enums;

namespace ExaBot
{
    class ClsRecibir
    {
        private static TelegramBotClient Bot;

        private void CargarArchivoExterno()
        {
            string fuente = @"C:\Users\alumno\Desktop\DatosProyecto\proyecto.csv";
            ClsSQL cnSQL = new ClsSQL();
            ClsArchivo ar = new ClsArchivo();
            string[] ArregloCarro = ar.LeerArchivo(fuente);
            int NumeroLinea = 0;
            string sentencia = "";
            foreach (string Linea in ArregloCarro)
            {
                string[] datos = Linea.Split(';');
                if (NumeroLinea >= 0)
                {
                    sentencia += $"insert into tb_carros values({datos[0]},'{datos[1]}',{datos[2]},{datos[3]},{datos[4]},{datos[5]});\n";
                }
                NumeroLinea++;
            }
            NumeroLinea = 0;
            cnSQL.EjecutaSQLDirecto(sentencia);
        }

        public async Task IniciarTelegram()
        {
            Bot = new TelegramBotClient("1838080255:AAHqgeKNsDG0YwfNgsEFUHkKlcS0YZpz0Ro");

            var me = await Bot.GetMeAsync();
            Console.Title = me.Username;

            Bot.OnMessage += BotCuandoRecibeMensajes;
            Bot.OnMessageEdited += BotCuandoRecibeMensajes;
            Bot.OnReceiveError += BotOnReceiveError;

            Bot.StartReceiving(Array.Empty<UpdateType>());
            Console.WriteLine($"Iniciando Bot @{me.Username}");

            Console.ReadLine();
            Bot.StopReceiving();
        }

        
        private static async void BotCuandoRecibeMensajes(object sender, MessageEventArgs messageEventArgumentos)
        {
            var ObjetoMensajeTelegram = messageEventArgumentos;
            var mensajes = ObjetoMensajeTelegram.Message;

            string mensajeEntrante = mensajes.Text;


            string respuesta = "Escribe la palabra (hola) para poder comenzar.Te recomendamos escribir en minúsculas";
            if (mensajes == null || mensajes.Type != MessageType.Text)
                return;
           

            if (mensajes.Text.Contains("hola"))
            {
                respuesta = "Buen día. ¿Te ha gustado alguna marca de auto?";
            }

            if (mensajes.Text.Contains("si"))
            {
                respuesta = "Comenta la marca de auto que te gustó";
            }

            if (mensajes.Text.Contains("no"))
            {
                respuesta = "Es una pena no poder ayudarte.";
            }

            if (mensajes.Text.Contains("nissan"))
            {
                respuesta = "¡Excelente! Pronto te vamos a contactar para continuar el proceso";
            }

            if (mensajes.Text.Contains("toyota"))
            {
                respuesta = "¡Muy bien! Estaremos en contacto";
            }

            if (mensajes.Text.Contains("mazda"))
            {
                respuesta = "¡Lo sentimos! Ya no se encuentran disponibles";
            }

            if (mensajes.Text.Contains("bmw"))
            {
                respuesta = "¡Qué mala suerte! Están agotados por ahora";
            }

            if (mensajes.Text.Contains("honda"))
            {
                respuesta = "¡Llegaste tarde! Se han acabado";
            }

            if (mensajes.Text.Contains("ford"))
            {
                respuesta = "¡Buena elección! Espero estés atento para poder contactarte";
            }

            if (mensajes.Text.Contains("adiós"))
            {
                respuesta = "Gracias por comunicarte, fue un gusto saludarte.";
            }

            if (!String.IsNullOrEmpty(respuesta))  
            {
                await Bot.SendTextMessageAsync(
                    chatId: ObjetoMensajeTelegram.Message.Chat,
                    parseMode: Telegram.Bot.Types.Enums.ParseMode.Markdown,
                    text: respuesta
            );
            }
        } 


        private static void BotOnReceiveError(object sender, ReceiveErrorEventArgs receiveErrorEventArgs)
        {
            Console.WriteLine("Recibiendo error: {0} — {1}",
                receiveErrorEventArgs.ApiRequestException.ErrorCode,
                receiveErrorEventArgs.ApiRequestException.Message
            );
        }
    }
}
