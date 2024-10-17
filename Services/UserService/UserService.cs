﻿using Model.DTO;
using Model.Entity;
using Data.DAO;

namespace Services.UserService
{
    public class UserService : IUserService
    {
        private readonly UserDAO _userDAO;

        public UserService(UserDAO userDAO)
        {
            _userDAO = userDAO;
        }

        public BedelDTO RegistrarBedel(BedelDTO bedelDTO)
        {
            var bedel = new Bedel(
                usuario: bedelDTO.Nombre,
                apellido: bedelDTO.Apellido,
                nombre: bedelDTO.Nombre,
                turno: bedelDTO.Turno
            );

            var nuevoBedel = _userDAO.AddBedel(bedel);

            bedelDTO.IdBedel = nuevoBedel.getId();

            return bedelDTO;
        }
    }
}
