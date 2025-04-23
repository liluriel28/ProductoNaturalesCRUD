﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Categoria
    {

        public static ML.Result GetAll()
        {
            ML.Result result = new ML.Result();

            try
            {
                using (DL_EF.ProductoNaturalesEntities context = new DL_EF.ProductoNaturalesEntities())
                {
                    var query = (from categoria in context.Categoria
                                 select new
                                 {
                                     IdCategoria = categoria.IdCategoria,
                                     Nombre = categoria.Nombre
                                 }).ToList();

                    if (query.Count > 0)
                    {

                        result.Objects = new List<object>();

                        foreach(var obj in query)
                        {
                            ML.Categoria categoria = new ML.Categoria()
                            {
                                IdCategoria = obj.IdCategoria,
                                Nombre = obj.Nombre
                            };

                            result.Objects.Add(categoria);
                        }
                        result.Success = true;

                    }
                }
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = ex.Message;
            }

            return result;
        }
    }
}
