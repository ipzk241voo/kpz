using QRCoder; 
using System.Drawing;

namespace ConsoleApp
{
    abstract class Document
    {
        public Action<string> _output = (str) => Console.WriteLine(str);

        public string LastName;
        public string FirstName;
        public string Photo;
        public int Year;

        protected Document(
            string LastName,
            string FirstName,
            string Photo,
            int Year
            )
        {
            this.LastName = LastName;
            this.FirstName = FirstName;
            this.Photo = Photo;
            this.Year = Year;
        }

        public string FullName()
        {
            return $"{LastName} {FirstName}";
        } 

        public void SetOutput(Action<string> output)
        {
            _output = output;
        }

        public abstract Bitmap generateQRCode();
    }

    class Passport : Document
    {
        private bool isHide;
        public string passportId;

        public Passport(
            string LastName, 
            string FirstName, 
            string Photo, 
            int Year, 

            string passportId
            ) : base(LastName, FirstName, Photo, Year)
        {
            this.passportId = passportId;
        }


        public void HideInfo()
        {
            isHide = !isHide;
        }

        public void ShowInfo()
        {
            if (!isHide)
            {
               _output("Information not available!");
                return;
            }

            _output(
                $"Name: {LastName} {FirstName}\n" + 
                $"Photo: {Photo}\n" + 
                $"Year: {Year}\n" + 
                $"PassId: {passportId}"
            );
        }

        public override Bitmap generateQRCode()
        {
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode($"{FullName()}_{passportId}_{DateTime.Now}", QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(20); 
            return qrCodeImage; 
        }
    }

    class DriveLicense : Document
    {
        public string licenseId;

        public List<string> licenseCategory;

        public DriveLicense(
            string LastName, 
            string FirstName, 
            string Photo, 
            int Year, 

            string licenseId, 
            List<string> licenseCategory

            ) : base(LastName, FirstName, Photo, Year)
        {
            this.licenseId = licenseId;
            this.licenseCategory = licenseCategory;
        }

        public override Bitmap generateQRCode()
        {
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode($"{FullName()}_{licenseId}_{DateTime.Now}", QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(20);
            return qrCodeImage;
        }
    }
}
