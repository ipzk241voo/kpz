using QRCoder;
using System;
using System.ComponentModel;
using System.Drawing;

namespace ConsoleApp
{
    public abstract class Document
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Photo { get; set; }
        public string DateOfBirth { get; set; }
        public string Gender { get; set; }


        protected Document(
            string LastName,
            string FirstName,
            string Photo,
            string DateOfBirth,
            string Gender
            )
        {
            this.LastName = LastName;
            this.FirstName = FirstName;
            this.Photo = Photo;
            this.DateOfBirth = DateOfBirth;
            this.Gender = Gender;
        }

        public string FullName() => $"{LastName} {FirstName}";

        public abstract string ShowInfo();
        public abstract Bitmap generateQRCode();
    }

    public class Passport : Document
    {
        private bool isHide;
        private string passportId;


        public string DateOfExpiry { get; set; }
        public string DateOfIssue { get; set; }
        public string Nationality { get; set; }


        public Passport(
            string LastName, 
            string FirstName, 
            string Photo, 
            string DateOfBirth,
            string Gender,

            string Nationality,
            string DateOfExpiry,
            string DateOfIssue,


            string passportId
            ) : base(LastName, FirstName, Photo, DateOfBirth, Gender)
        {
            this.Nationality= Nationality;
            this.DateOfExpiry= DateOfExpiry;
            this.DateOfIssue= DateOfIssue;
            this.passportId = passportId;
        }


        public void HideInfo()
        {
            isHide = !isHide;
        }

        public string CopyIdentificationCode() => $"Code: {passportId}";

        public override string ShowInfo()
        {
            if (isHide)
            {
                return "Information is hidden!";
            }

            return $"Name: {FullName()}\n" +
                   $"Gender: {Gender}\n" +
                   $"Photo: {Photo}\n" +
                   $"Date of Birth: {DateOfBirth}\n" +
                   $"Passport ID: {passportId}\n" +
                   $"Nationality: {Nationality}\n" +
                   $"Date of Issue: {DateOfIssue}\n" +
                   $"Date of Expiry: {DateOfExpiry}";
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

    public class Military: Document
    {
        public string militaryId { get; set; }
        public string DateOfIssue { get; set; }
        public string Rank { get; set; }

        public Military(
            string LastName,
            string FirstName,
            string Photo,
            string DateOfBirth,
            string Gender,

            string militaryId,
            string DateOfIssue,
            string Rank
            ) : base(LastName, FirstName, Photo, DateOfBirth, Gender)
        {
            this.militaryId = militaryId;
            this.DateOfIssue = DateOfIssue;
            this.Rank = Rank;
        }

        public string CopyIdentificationCode() => $"Code: {militaryId}";


        public override string ShowInfo()
        {
            return $"Name: {FullName()}\n" +
                   $"Gender: {Gender}\n" +
                   $"Photo: {Photo}\n" +
                   $"Date of Birth: {DateOfBirth}\n" +
                   $"Date of Issue: {DateOfIssue}\n" +
                   $"Military ID: {militaryId}\n" +
                   $"Rank: {Rank}";
        }

        public override Bitmap generateQRCode()
        {
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode($"{FullName()}_{militaryId}_{DateTime.Now}", QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(20);
            return qrCodeImage;
        }
    }

    public class Car
    {
        public string Mark { get; set; }
        public string Number { get; set; }
        public string VIN { get; set; }

        public Car(string mark, string number, string vIN)
        {
            Mark = mark;
            Number = number;
            VIN = vIN;
        }
    }

    public class DriveLicense : Document
    {
        public string licenseId { get; set; }
        public string passportId { get; set; }

        public List<string> licenseCategory;

        public List<Car> cars;

        public DriveLicense(
            string LastName,
            string FirstName,
            string Photo,
            string DateOfBirth,
            string Gender,

            string licenseId,
            List<string>? licenseCategory,
            List<Car>? cars

            ) : base(LastName, FirstName, Photo, DateOfBirth, Gender)
        {
            this.licenseId = licenseId;
            this.licenseCategory = licenseCategory;
            this.cars = cars;
        }

        public string CopyIdentificationCode() => $"Code: {licenseId}";

        public void addLicCar(string category) => licenseCategory.Add(category);
        public void delLicCar(string category) => licenseCategory.RemoveAt(licenseCategory.IndexOf(category));

        public void addCar(Car car) => cars.Add(car);
        public void delCar(string VIN) => cars.RemoveAt(cars.FindIndex(c => c.VIN.Equals(VIN)));

        public override string ShowInfo()
        {
            return $"Name: {FullName()}\n" +
                   $"Gender: {Gender}\n" +
                   $"Photo: {Photo}\n" +
                   $"Date of Birth: {DateOfBirth}\n" +
                   $"License ID: {licenseId}\n" +
                   $"License Category: {string.Join(", ", licenseCategory)}\n" +
                   $"Cars: {string.Join(", ", cars.Select(c => c.Mark))}";
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

    public class DocumentContainer
    {
        public Action<string> _output = (str) => Console.WriteLine(str);

        private List<Document> documents = new List<Document>();

        public void swapDocument(int i1, int i2)
        {
            var temp = documents[i1];
            documents[i1] = documents[i2];
            documents[i1] = temp;
        }

        public void addDoc(Document doc) => documents.Add(doc);
        public void delDoc(int index) => documents.RemoveAt(index);

        public List<Document> getDocuments() => documents;

        public List<Document> findDocFullName(string lastName, string firstName) =>
            documents.FindAll(d => d.FirstName == firstName && d.LastName == lastName).ToList();


        public void SetOutput(Action<string> output)
        {
            _output = output;
        }

        public void showAllInfo()
        {
            foreach(Document doc in documents)
            {
               _output.Invoke($"{doc.ShowInfo()}\n====================");
            }
        }
    }
}
