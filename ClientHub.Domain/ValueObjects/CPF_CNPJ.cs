using System;
using System.Text.RegularExpressions;

namespace ClientHub.Domain
{
    public class CPF_CNPJ
    {
        public string Value { get; set; }

        public CPF_CNPJ(string value)
        {
            if (string.IsNullOrEmpty(value))
                throw new ArgumentException("CPF/CNPJ não pode ser vazio.");

            var numbers = Regex.Replace(value, @"[^\d]", "");

            if (numbers.Length == 11)
            {
                if (!ValidateCPF(numbers))
                    throw new ArgumentException("CPF inválido.");
            }
            else if (numbers.Length == 14)
            {
                if (!ValidateCNPJ(numbers))
                    throw new ArgumentException("CNPJ inválido.");
            }
            else
            {
                throw new ArgumentException("CPF/CNPJ deve ter 11 ou 14 dígitos.");
            }

            Value = numbers;
        }

        public override string ToString()
        {
            if (Value.Length == 11)
                return Convert.ToInt64(Value).ToString(@"000\.000\.000\-00");
            else
                return Convert.ToInt64(Value).ToString(@"00\.000\.000\/0000\-00");
        }

        private bool ValidateCPF(string cpf)
        {
            int[] multiplicator1 = { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicator2 = { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            cpf = cpf.Trim();
            cpf = cpf.Replace(".", "").Replace("-", "");

            if (cpf.Length != 11)
                return false;

            var tempCpf = cpf.Substring(0, 9);
            int sum = 0;

            for(int i = 0; i < 9; i++)
                sum += int.Parse(tempCpf[i].ToString()) * multiplicator1[i];

            int rest = sum % 11;

            if (rest < 2)
                rest = 0;
            else
                rest = 11 - rest;

            var digit = rest.ToString();
            tempCpf += digit;

            sum = 0;

            for (int i = 0; i < 10; i++)
                sum += int.Parse(tempCpf[i].ToString()) * multiplicator2[i];

            rest = sum % 11;
            if (rest > 2)
                rest = 0;
            else
                rest = 11 - rest;

            digit += rest.ToString();

            return cpf.EndsWith(digit);
        }

        private bool ValidateCNPJ(string cnpj)
        {
            int[] multiplicator1 = { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicator2 = { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };

            cnpj = cnpj.Trim();
            cnpj = cnpj.Replace(".", "").Replace("-", "").Replace("/", "");

            if (cnpj.Length != 14)
                return false;

            string tempCnpj = cnpj.Substring(0, 12);
            int sum = 0;

            for (int i = 0; i < 12; i++)
                sum += int.Parse(tempCnpj[i].ToString()) * multiplicator1[i];

            int rest = (sum % 11);
            if (rest < 2)
                rest = 0;
            else
                rest = 11 - rest;

            string digit = rest.ToString();
            tempCnpj += digit;

            sum = 0;

            for (int i = 0; i < 13; i++)
                sum += int.Parse(tempCnpj[i].ToString()) * multiplicator2[i];

            rest = (sum % 11);
            if (rest < 2)
                rest = 0;
            else
                rest = 11 - rest;

            digit += rest.ToString();

            return cnpj.EndsWith(digit);
        }
    }
}
