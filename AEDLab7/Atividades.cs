using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AEDLab7
{
    public static class Atividades
    {
        public static void Exercicio2()
        {
            /** AULA 10/08/2019 @AUTOR Danrley Costa
             * Questão 5 - (Herança)
             * a)Implemente o esquema visto no diagrama acima e realize os testes criando uma
             * instância de cada um dos patos e imprimindo na tela cada um dos comportamentos
             * descritos na classe Duck.
             * b) Sobrescreva os métodos na classes filhas do comportamento de display(), onde o
             * RedHeadDuck devera mostrar em seu display: “Sou um pato Vermelho” e a classe
             * MallardDuck terá o display: “Eu sou um pato mau”.
             */
            Duck myDuck = new Duck();
            RedHeadDuck myRedDuck = new RedHeadDuck();
            MallardDuck myMallard = new MallardDuck();
            myDuck.display();
            myRedDuck.quack();
            myRedDuck.display();
            myMallard.display();
            myMallard.fly();

            /**
             * -----------------------------------------------------------
             * 2) Explique quais os principais
             * ganhos desta estratégia?
             * 
             * - Quando ser quer implementar algo em uma determinada situação de urgencia (ex: "Quebrar um galho") para 
             *   ter um funcionamento imediato (mas não e uma boa pratica).
             * - Definição de um "contrato" para se utilizar, auxiliando na organização do codigo
             * - Permitem criar sistemas fracamente acoplados e mais flexível a mudanças
             * - Programar para interface deixa o código mais flexível, permitindo trocar a implementação de um componente
             * 
             * 3)Você é capaz de ver alguma
             * desvantagem nesta estratégia?
             * 
             * - Suporte apenas para constantes do tipo estática.
             * - Lento, requer trabalho extra para encontrar o método correspondente na classe atual.
             * - Se você incluir um novo método em uma interface você precisa ajustar todas as implementações da interface.
             */
        }

    }
}
