namespace review_test
{
    class Delegate12{
        public delegate void NotificationHandler();
    }
    class Notification12{
        public void EmailNotification(){
            Console.WriteLine($"day la mot thong bao tu email");
        }
        public void SmsNotification(){
            Console.WriteLine($"day la mot thong bao tu sms");
        }
    }
}