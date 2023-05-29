namespace BeautyBooking.Common
{
    public static class GlobalConstants
    {
        public const string SystemName = "DVOR21";

        public const string AdministratorRoleName = "Administrator";

        public const string SalonManagerRoleName = "Manager";

        public const string CloudName = "dvor21";

        public static class AccountsSeeding
        {
            public const string Password = "123456";

            public const string AdminEmail = "admin@admin.com";

            public const string SalonManagerEmail = "manager@manager.com";

            public const string UserEmail = "user@user.com";
        }

        public static class DataValidations
        {
            public const int TitleMaxLength = 60;

            public const int TitleMinLength = 5;

            public const int ContentMaxLength = 3500;

            public const int ContentMinLength = 700;

            public const int NameMaxLength = 40;

            public const int NameMinLength = 2;

            public const int DescriptionMaxLength = 700;

            public const int DescriptionMinLength = 50;

            public const int AddressMaxLength = 100;

            public const int AddressMinLength = 5;
        }

        public static class ErrorMessages
        {
            public const string Title = "Заголовок должен содержать от 5 до 60 символов.";

            public const string Content = "Содержание должно составлять от 700 до 3500 символов.";

            public const string Author = "Имя автора должно содержать от 2 до 40 символов.";

            public const string Name = "Имя должно содержать от 2 до 40 символов.";

            public const string Description = "Описание должно содержать от 50 до 700 символов.";

            public const string Address = "Адрес должен содержать от 5 до 100 символов.";

            public const string Image = "Пожалуйста, выберите изображение в формате JPG, JPEG или PNG размером менее 1 МБ.";

            public const string DateTime = "Пожалуйста, выберите действительные ДАТУ и ВРЕМЯ из календаря слева.";

            public const string Rating = "Пожалуйста, выберите допустимое количество звезд от 1 до 5.";
        }

        public static class DateTimeFormats
        {
            public const string DateFormat = "dd-MM-yyyy";

            public const string TimeFormat = "h:mmtt";

            public const string DateTimeFormat = "dd-MM-yyyy h:mmtt";
        }

        public static class Images
        {

            public const string Index = "https://res.cloudinary.com/dt9pqai7e/image/upload/v1683782732/handsome-man-barbershop-shaving-beard_anoquc.png";

            public const string CoverBackground = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRGWxNN1l9DW3wM41Pk7r8EoCYL8zQGhYDwn4FQF_Oqloud24RKhsxe0Oz1sZvQD4rgXvw&usqp=CAUe";

            public const string Footer = "https://res.cloudinary.com/beauty-booking/image/upload/v1586874219/footer_rvuuls.jpg";

            public const string Error404 = "https://res.cloudinary.com/beauty-booking/image/upload/v1587754604/404_mcjscs.jpg";

            public const string CloudinaryMissing = "https://res.cloudinary.com/beauty-booking/image/upload/v1587708556/cloudinary_veibtu.png";


            // Categories
            public const string Hair = "https://res.cloudinary.com/beauty-booking/image/upload/v1587149548/Categories/hair_wufoua.jpg";

            public const string HairRemoval = "https://res.cloudinary.com/beauty-booking/image/upload/v1587149548/Categories/waxing_svksmn.jpg";

            public const string Massage = "https://res.cloudinary.com/beauty-booking/image/upload/v1587149548/Categories/massage_ocfk8z.jpg";

            public const string Nails = "https://res.cloudinary.com/beauty-booking/image/upload/v1587149548/Categories/nails_dyy9ik.jpg";

            public const string Face = "https://res.cloudinary.com/beauty-booking/image/upload/v1587149548/Categories/face_hmgpb4.jpg";

            public const string Body = "https://res.cloudinary.com/beauty-booking/image/upload/v1587149548/Categories/body_dfc8jw.png";

            // Salons
            public const string Hair1 = "https://res.cloudinary.com/beauty-booking/image/upload/v1587257302/Salons/hair-1_jrtnzq.jpg";

            public const string Hair2 = "https://res.cloudinary.com/beauty-booking/image/upload/v1587257302/Salons/hair-2_x39q2k.jpg";

            public const string Hair3 = "https://res.cloudinary.com/beauty-booking/image/upload/v1587257302/Salons/hair-3_tmtty0.jpg";

            public const string HairRemoval1 = "https://res.cloudinary.com/beauty-booking/image/upload/v1587257302/Salons/wax-1_tj3yxa.jpg";

            public const string HairRemoval2 = "https://res.cloudinary.com/beauty-booking/image/upload/v1587257302/Salons/wax-2_yhaawx.jpg";

            public const string HairRemoval3 = "https://res.cloudinary.com/beauty-booking/image/upload/v1587257303/Salons/wax-3_eldlfp.jpg";

            public const string Massage1 = "https://res.cloudinary.com/beauty-booking/image/upload/v1587257302/Salons/massage-1_v7pkjb.jpg";

            public const string Massage2 = "https://res.cloudinary.com/beauty-booking/image/upload/v1587257302/Salons/massage-2_kycian.jpg";

            public const string Massage3 = "https://res.cloudinary.com/beauty-booking/image/upload/v1587257302/Salons/massage-3_uxwss5.jpg";

            public const string Nails1 = "https://res.cloudinary.com/beauty-booking/image/upload/v1587257302/Salons/nails-1_twjz2q.jpg";

            public const string Nails2 = "https://res.cloudinary.com/beauty-booking/image/upload/v1587257302/Salons/nails-2_chlj7f.jpg";

            public const string Nails3 = "https://res.cloudinary.com/beauty-booking/image/upload/v1587257302/Salons/nails-3_ysgryj.jpg";

            public const string Face1 = "https://res.cloudinary.com/beauty-booking/image/upload/v1587257301/Salons/face-1_lduuj9.jpg";

            public const string Face2 = "https://res.cloudinary.com/beauty-booking/image/upload/v1587257301/Salons/face-2_lblaut.jpg";

            public const string Face3 = "https://res.cloudinary.com/beauty-booking/image/upload/v1587257301/Salons/face-3_tckbu3.jpg";

            public const string Body1 = "https://res.cloudinary.com/beauty-booking/image/upload/v1587257301/Salons/body-1_prilhb.jpg";

            public const string Body2 = "https://res.cloudinary.com/beauty-booking/image/upload/v1587257301/Salons/body-2_pivi9c.jpg";

            public const string Body3 = "https://res.cloudinary.com/beauty-booking/image/upload/v1587257301/Salons/body-3_x95ezf.jpg";
        }

        public static class SeededDataCounts
        {
            public const int Categories = 1;

            public const int Services = 4;

            public const int Cities = 2;

            public const int Salons = 1;

            public const int Appointments = 55;
        }
    }
}
