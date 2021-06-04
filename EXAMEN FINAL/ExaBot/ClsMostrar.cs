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
using Telegram.Bot.Types.ReplyMarkups;

namespace ExaBot
{
    class ClsMostrar
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


        public async Task InicioTelegram()               
        {
            Bot = new TelegramBotClient("1838080255:AAHqgeKNsDG0YwfNgsEFUHkKlcS0YZpz0Ro");

            Bot.OnMessage += BotOnMessageReceived;
            Bot.OnMessageEdited += BotOnMessageReceived;
            Bot.OnCallbackQuery += BotOnCallbackQueryReceived;
            Bot.OnReceiveError += BotOnReceiveError;

            Bot.StartReceiving();
            Console.WriteLine("Bot iniciado");
            Console.ReadLine();
            Bot.StopReceiving();

        }

        private static async void BotOnMessageReceived(object sender, MessageEventArgs messageEventArgs)
        {
            var message = messageEventArgs.Message;

            if (message == null || message.Type != MessageType.Text) return;

            switch (message.Text.Split(' ').First())
            {
                //Enviar un inline keyboard con callback
                case "/1":

                    //Simula que el bot está escribiendo
                    await Bot.SendChatActionAsync(message.Chat.Id, ChatAction.Typing);

                    var keyboardEjemplo1 = new InlineKeyboardMarkup(new[]
                    {
                    new []
                    {
                        InlineKeyboardButton.WithCallbackData(
                            text:"Video",
                            callbackData: "video"),

                    },
                    new []
                    {
                        InlineKeyboardButton.WithCallbackData(
                            text:"Ubicación",
                            callbackData: "ubicacion"),
                    },
                     new []
                    {
                        InlineKeyboardButton.WithCallbackData(
                            text:"Contacto",
                            callbackData: "contacto"),
                    },
                    new []
                    {
                        InlineKeyboardButton.WithCallbackData(
                            text:"Animación",
                            callbackData: "animacion"),
                    }
                });

                    await Bot.SendTextMessageAsync(
                        message.Chat.Id,
                        "Escoge una opción",
                        replyMarkup: keyboardEjemplo1);
                    break;

                case "/2":

                    var keyboardEjemplo2 = new InlineKeyboardMarkup(new[]
                    {
                    new []
                    {
                        InlineKeyboardButton.WithCallbackData(
                            text:"Toyota",
                            callbackData: "toyota"),
                        InlineKeyboardButton.WithCallbackData(
                            text:"Nissan",
                            callbackData: "nissan"),
                    },
                    new []
                    {
                        InlineKeyboardButton.WithCallbackData(
                            text:"Mazda",
                            callbackData: "mazda"),
                        InlineKeyboardButton.WithCallbackData(
                            text:"BMW",
                            callbackData: "bmw"),
                    },
                    new []
                    {
                        InlineKeyboardButton.WithCallbackData(
                            text:"Honda",
                            callbackData: "honda"),
                        InlineKeyboardButton.WithCallbackData(
                            text:"Ford",
                            callbackData: "ford"),
                    }

                });

                    await Bot.SendTextMessageAsync(
                        message.Chat.Id,
                        "¡Tú decides!",
                        replyMarkup: keyboardEjemplo2);
                    break;

                //Mensaje por default
                default:
                    const string usage = @"
                ¡Escoge la opcion que deseas!:
                /1 
                /2";

                    await Bot.SendTextMessageAsync(
                        message.Chat.Id,
                        text: usage,
                        replyMarkup: new ReplyKeyboardRemove());
                    break;
            }
        }

        private static async void BotOnCallbackQueryReceived(object sender, CallbackQueryEventArgs callbackQueryEventArgs)
        {
            var callbackQuery = callbackQueryEventArgs.CallbackQuery;


            switch (callbackQuery.Data)
            {
                case "ubicacion":
                    await Bot.SendVenueAsync(
                        chatId: callbackQuery.Message.Chat.Id,
                        latitude: 14.29167f,
                        longitude: -89.89583f,
                        title: "Guatemala",
                        address: "Asuncion Mita, Jutiapa"
                        );
                    break;

                case "video":
                    await Bot.SendVideoAsync(
                        chatId: callbackQuery.Message.Chat.Id,
                        video: "https://static.videezy.com/system/resources/previews/000/004/298/original/22.mp4"
                        );
                    break;

                case "animacion":
                    await Bot.SendAnimationAsync(
                        chatId: callbackQuery.Message.Chat.Id,
                        animation: "https://media3.giphy.com/media/TeXVQ0AFBukqA/200.gif"
                        );
                    break;

                case "contacto":
                    await Bot.SendContactAsync(
                       chatId: callbackQuery.Message.Chat.Id,
                       phoneNumber: "4035-1075",
                       firstName: "Juan",
                       lastName: "Mecanico"
                       );
                    break;

                case "nissan":
                    await Bot.SendPhotoAsync(
                        chatId: callbackQuery.Message.Chat.Id,
                        photo: "https://www.autolist.com/6tuem73u73an/5dOydaXrTWyo5j5qaFmR1u/bb988aef479f3452b1d1b84a917f5205/2020-nissan-sentra-exterior-image.jpg"
                        );

                    await Bot.SendTextMessageAsync(
                       chatId: callbackQuery.Message.Chat.Id,
                       text: "Nissan Micra Q70,000"
                       );
                    break;

                case "toyota":
                    await Bot.SendPhotoAsync(
                        chatId: callbackQuery.Message.Chat.Id,
                        photo: "https://upload.wikimedia.org/wikipedia/commons/3/3e/2020_Toyota_Yaris_Design_HEV_CVT_1.5_Front.jpg"
                        );

                    await Bot.SendTextMessageAsync(
                       chatId: callbackQuery.Message.Chat.Id,
                       text: "Toyota Yaris Q60,000"
                       );
                    break;

                case "mazda":
                    await Bot.SendPhotoAsync(
                         chatId: callbackQuery.Message.Chat.Id,
                         photo: "https://media.ed.edmunds-media.com/mazda/mpv/2006/oem/2006_mazda_mpv_passenger-minivan_lx_fq_oem_1_500.jpg"
                         );

                    await Bot.SendTextMessageAsync(
                       chatId: callbackQuery.Message.Chat.Id,
                       text: "Mazda MPV Q40,000"
                       );
                    break;

                case "bmw":
                    await Bot.SendPhotoAsync(
                         chatId: callbackQuery.Message.Chat.Id,
                         photo: "https://i.ytimg.com/vi/qjP-eFn8Nk4/maxresdefault.jpg"
                         );

                    await Bot.SendTextMessageAsync(
                       chatId: callbackQuery.Message.Chat.Id,
                       text: "BMW Tourer Q100,000"
                       );
                    break;

                case "honda":
                    await Bot.SendPhotoAsync(
                         chatId: callbackQuery.Message.Chat.Id,
                         photo: "https://cdn2.buyacar.co.uk/sites/buyacar/files/honda-e-1_0.jpg"
                         );

                    await Bot.SendTextMessageAsync(
                       chatId: callbackQuery.Message.Chat.Id,
                       text: "Honda E Q50,000"
                       );
                    break;

                case "ford":
                    await Bot.SendPhotoAsync(
                         chatId: callbackQuery.Message.Chat.Id,
                         photo: "https://www.motor.es/fotos-noticias/2020/09/precio-ford-ecosport-2021-202071406-1601317865_1.jpg"
                         );

                    await Bot.SendTextMessageAsync(
                       chatId: callbackQuery.Message.Chat.Id,
                       text: "Ford EcoSport Q80,000"
                       );
                    break;
            }
        }

        private static void BotOnReceiveError(object sender, ReceiveErrorEventArgs receiveErrorEventArgs)
        {
            Console.WriteLine("Recibiendo error: {0} — {1}",
                receiveErrorEventArgs.ApiRequestException.ErrorCode,
                receiveErrorEventArgs.ApiRequestException.Message);
        }
    }
}
    

