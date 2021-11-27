using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidades;
using Datos;


namespace Negocio
{
    public class nPaciente
    {
        dPaciente datos_paciente;

        public nPaciente()
        {
            datos_paciente = new dPaciente();
        }

        public string RegistrarPaciente(string dni, string nom, string sex, string distri, int FechaN, int FechaR)
        {
            ePaciente paciente = new ePaciente()
            {
                DNI = dni,
                NombreCompleto = nom,
                Sexo = sex,
                Distrito = distri,
                FechaNacimiento = FechaN,
                FechaRegistro = FechaR
            };
            return datos_paciente.Insertar(paciente);
        }
        
        public string EliminarPaciente(string DNI)
        {
            return datos_paciente.Eliminar(DNI);
        }

        public string ModificarPaciente(string nom, string sex, string distri, int FechaN, int FechaR, string dni) {
            ePaciente paciente = new ePaciente()
            {
                DNI = dni,
                NombreCompleto = nom,
                Sexo = sex,
                Distrito = distri,
                FechaNacimiento = FechaN,
                FechaRegistro = FechaR
            };
            return datos_paciente.Modificar(paciente, paciente.DNI);

        }

        public List<ePaciente> ListarPacientes()
        {
            return datos_paciente.ListarTodoPacientes();
        }

        public bool ExistePaciente(string DNI)
        {
            return ListarPacientes().Exists(delegate (ePaciente value)
            {
                return value.DNI == DNI;
            });
        }


        public List<ePaciente> ListarMayorTiempoRegistrados()
        {
            ePaciente aux = ListarPacientes().ElementAt(0);
            foreach(ePaciente var in ListarPacientes())
            {
                if (var.Registro() > aux.Registro()) aux = var;
            }

            List<ePaciente> lista = new List<ePaciente>();
            lista = ListarPacientes().FindAll(delegate (ePaciente value)
            {
                return value.Registro() == aux.Registro();
            });
            return lista;
        }

        public string DistritoMenorNroVaros()
        {

            //CERCADO BARRANCO SURCO CALLAO
            string distritos = "";
            int[] cantidad_varos = new int[4];
            for (short i = 0; i < 4; i++) {
                cantidad_varos[i] = 0;
            }

            foreach(ePaciente paciente in ListarPacientes())
            {
                if(paciente.Sexo == "Masculino")
                {
                    switch (paciente.Distrito)
                    {
                        case "Cercado": cantidad_varos[0]++; break;
                        case "Barranco": cantidad_varos[1]++; break;
                        case "Surco": cantidad_varos[2]++; break;
                        case "Callao": cantidad_varos[3]++; break;
                    }
                }
            }

            int menor = 999;

            for(short i=0; i < 4; i++)
            {
                if (cantidad_varos[i] <= menor) menor = cantidad_varos[i];
            }

            distritos += "Menor cantidad de varones: " + menor;

            for (short i = 0; i < 4; i++)
            {
                if (cantidad_varos[i] == menor)
                {
                    switch (i)
                    {
                        case 0: distritos += "\nCercado"; break;
                        case 1: distritos += "\nBarranco"; break;
                        case 2: distritos += "\nSurco"; break;
                        case 3: distritos += "\nCallao"; break;
                    }
                }
            }

            return distritos;


        }

        public string CantidadNiñosJovenes(string distrito)
        {
            //niños +=6 y -=11
            //jovenes +=18 y -=25
            string info = "";
            int[] cont = new int[2];
            for (short i = 0; i < 2; i++) {
                cont[i] = 0;
            }

            foreach (ePaciente paciente in ListarPacientes())
            {
                if (paciente.Distrito == distrito)
                {
                    if (paciente.Edad() >= 6 && paciente.Edad() <= 11) cont[0]++;
                    else if (paciente.Edad() >= 18 && paciente.Edad() <= 25) cont[1]++;
                }
            }

            info += "Niños (de 6 a 11 años): " + cont[0] + "\n";
            info += "Jovenes (de 18 a 25 años): " + cont[1] + "\n";

            return info;
        }


        }


    }
