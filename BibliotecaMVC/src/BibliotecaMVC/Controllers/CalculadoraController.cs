using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BibliotecaMVC.Controllers
{
    public class CalculadoraController : Controller
    {
        public string Index()
        {
            return "Olá, pessoas";
        }
        public string NovaMensagem(string valor)
        {
            return "O Valor passado foi:" + valor;
        }
        public string soma (decimal valor1, decimal valor2)
        {
            decimal resultado = valor1+valor2;
            return "O Valor passado para soma foi: " + valor1 + " e " + valor2 + ". Resultado: " + resultado;

        }

        public string subtracao(decimal valor1, decimal valor2)
        {
            decimal resultado = valor1 - valor2;
            return "O Valor passado para subtração foi: " + valor1 + " e " + valor2 + ". Resultado: " + resultado;
        }

        public string divisao(decimal valor1, decimal valor2)
        {
            if (valor2 == 0) return "Não é possível dividir por zero";

            decimal resultado = valor1 / valor2;
            return "O Valor passado para divsão foi: " + valor1 + " e " + valor2 + ". Resultado: " + resultado;
        }

        public string multiplicacao(decimal valor1, decimal valor2)
        {
            decimal resultado = valor1 * valor2;
            return string.Format("{0:N4} * {1:N4} = {2:N4}", valor1, valor2, resultado);
        }

    }
}