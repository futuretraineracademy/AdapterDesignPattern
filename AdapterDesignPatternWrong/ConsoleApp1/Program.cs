// See https://aka.ms/new-console-template for more information
using ConsoleApp1.Classes;

Console.WriteLine("Hello, World!");

VideoManager videoManager = new VideoManager();
videoManager.UploadVideo(VideoPlatform.Vimeo, new byte[1]);