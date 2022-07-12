using Core.Utilities.Messages;
using Core.Utilities.Results;
using Core.Utilities.Results.Abstracts;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Core.Utilities.Helpers
{
    public class FileHelper : IFileHelper
    {
        private static string CurrentDirectory = Environment.CurrentDirectory + "\\wwwroot";
        public static string GetCurrentDirectory { get { return CurrentDirectory; } private set { } }

        private static string _folderName = "\\img\\";

        public void CheckDirectoryExists(string directory)
        {
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }
        }

        public IResult CheckFileTypeValid(string type)
        {
            if (type != ".jpeg" && type != ".png" && type != ".jpg")
            {
                return new ErrorResult(HelperMessages.WrongFileType);
            }
            return new SuccessResult();
        }

        public async void CreateFile(string directory, IFormFile file)
        {
            using (FileStream stream = File.Create(directory))
            {
                await file.CopyToAsync(stream);
                stream.Flush();
            }
        }

        public IResult Upload(IFormFile file)
        {
            if (file != null)
            {
                string directory = CurrentDirectory;
                string imageExtension = Path.GetExtension(file.FileName);
                string imageName = Guid.NewGuid().ToString();

                var typeResult = CheckFileTypeValid(imageExtension);
                if (!typeResult.Success)
                {
                    return new ErrorResult(typeResult.Message);
                }

                CheckDirectoryExists(directory + _folderName);
                CreateFile(directory + _folderName + imageName + imageExtension, file);
                return new SuccessResult((_folderName + imageName + imageExtension).Replace("\\", "/"));
            }
            return new ErrorResult(HelperMessages.EmptyFile);
        }
    }
}
