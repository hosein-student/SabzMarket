using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SabzMarket.Share
{
    public class Messages
    {
        public const string InternetErrorMessage = "اتصال اینترنت خود را بررسی کنید و دوباره تلاش کنید. در صورت تکرار مشکل، با پشتیبانی تماس بگیرید.";
        public const string Url = "https://";
        //======================================================================================================
        public const string successSignUp1 = "ثبت نام اولیه شما انجام شد";
        public const string failedSignUp1 = "ثبت نام اولیه شما انجام نشد ";
        public const string passwordNotMatch = "پسورد ها مطابقت ندارد";
        public const string existingUser = "این نام کاربری توسط شخصی دیگر انتخاب شده";
        public const string numberInvalid1 = "شماره تلفن کامل نمی باشد ";
        public const string lastNameInvalid1 = "نام خانوادگی رادرست وارد کنید";
        public const string lastNameInvalid2 = "نام خانوادگی طولانی است";
        public const string firstNameInvalid1 = "نام نمی تواند کمتر از سه حرف باشد";
        public const string firstNameInvalid2 = "نام طولانی است";
        public const string numberInvalid2 = "شماره تلفن معتبر نمی باشد ";
        public const string EmailInvalid = "ایمیل معتبر نمی باشد";
        public const string EnterPassword = "پسوردی برای خود انتخاب کنید";
        public const string successSignUp2 = "ثبت نام شما انجام شد";
        public const string failedSignUp2 = "ثبت نام شما انجام نشد";
        public const string notSavePhoto = "مشکلی پیش امده عکس ذخیره نشد";
        public const string photoNotSelected = "لطفا یک عکس برای پروفایل خود انتخاب کنید";
        public const string enterTheAddress = "آدرس را وارد کنید";
        public const string enterTheWorkHistory = "سابقه کاری نمی تواند کمتر از 1 رقم و بیشتر از سه رقم باشد.";
        public const string error = "مشکلی پیش امده لطفا با پشتیبانی تماس بگیرید";
        public const string codeError = "کد خطا:  ";
        public const string update = "ویرایش شد";
        public const string Mandatory = "فیلد های اجباری را وارد کنید";
        public const string userNotLogin = "اطلاعات ورود نامعتبر است اگر ثبت نام نکرده اید ابتدا ثبت نام کنید سپس وارد شوید";
        //==============================================================================================================================
        public const string ProductName = "لطفا نام محصول را وارد کنید";
        public const string ProductPrice = "لطفا قیمت محصول را وارد کنید";
        public const string ValidProductPrice = "لطفا قیمت محصول را به عدد وارد کنید";
        public const string ProductNumber = "تعداد محصول را وارد کنید";
        public const string ProductDescription = "لطفا توضیحات محصول را وارد کنید";
        public const string ProductDescriptionLength = "توصیحات نمی تواند بیشتر از 500 حرف باشد";
        public const string ProductCategory = "لطفا دسته بندی محصول را وارد کنید";
        public const string ProductPhoto = "لطفا عکسی برای محصول آپلود کنید";
        public const string ProductAdded = "محصول با موفقیت اضافه شد";
        public const string ConfirmDeleteProduct = "آیا از حذف محصول مطمئن هستید؟";
        public const string DeleteProduct = "محصول حذف شد";
        public const string ProductHasUnsentOrders = "این محصول دارای سفارش ارسال‌نشده است. لطفاً ابتدا سفارش‌های مربوطه را ارسال کنید و سپس دوباره برای حذف محصول اقدام نمایید.";
        //=================================================================================================================
        public const string NullOrder = "سفارش پیدا نشد";
        public const string RejectedOrder = "سفارش رد شد";
        public const string SentOrder = "سفارش ارسال شد";
        //====================================================================================================================
        public const string EnterDataBuilt = "تاریخ احداث را با فرمت 1380/12/24 وارد کنید ";
        public const string EnterLandArea = "مساحت زمین قابل کشت را به عدد وارد کنید";
        public const string EnterCodParvaneBHB = "شماره پروانه بهره برداری را درست وارد کنید";
        public const string EnterCodePosti = "کد پستی را درست وارد کنید";
        public const string NotValidNationalCode = "کد ملی معتبر نیست";
    }
}
