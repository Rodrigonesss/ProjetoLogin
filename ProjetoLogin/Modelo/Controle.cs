﻿using ProjetoLogin.Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLogin.Modelo
{
    public class Controle
    {
        public bool tem;
        public String mensagem = "";
        public bool acessar(String login, String senha)
        {
            LoginDaoComandos loginDao = new LoginDaoComandos();
            tem = loginDao.verificarLogin(login, senha);
            if(!loginDao.mensagem.Equals (""))
            {
                this.mensagem = loginDao.mensagem;
            }
            return tem;
        }
        public String cadastrar (String email, String senha,  String confiSenha)
        {
            LoginDaoComandos loginDao = new LoginDaoComandos();
           this.mensagem = loginDao.cadastrar(email, senha, confiSenha);
            if (loginDao.tem)//a mensagem que vai vir e de sucesso
            {
                this.tem = true;  
            }
            return mensagem;
        }
    }
}
