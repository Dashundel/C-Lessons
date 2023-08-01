namespace HW456;

public abstract class Lesson4
{
    /// <summary>
    /// Создать класс “Телефон”, который содержит следующие данные:
    /// код города, номер телефона, которые не могут быть изменены.
    /// Добавить метод, который возвращает строку вида “(999) 999999” или “999999”,
    /// если код города отсутствует.
    /// Преобразовать класс “Телефон” на работу со свойствами
    /// </summary>

    public class Telephone
    {
        public readonly int _cityCode;
        public readonly string _phoneNumber;

        public int?  CityCode
        {
            get { return _cityCode; }
        }
        
        public string PhoneNumber
        {
            get { return _phoneNumber; }
        }

        public Telephone(int code, string phone)
        {
            _cityCode = code;
            _phoneNumber = phone;
        } 
        
        public string PhoneNumberWithoutCode()
        {
            string number = PhoneNumber;
            
            if (CityCode != null)
            {
                return "+" + CityCode.ToString() + PhoneNumber;
            }
            else
            {
                var onlyNumbers = new string(number.Where(c => char.IsDigit(c)).ToArray());
               
                if (onlyNumbers.Length < 9)
                {
                    return number;
                }
                else
                    return onlyNumbers; 
            }
        }
    }
}