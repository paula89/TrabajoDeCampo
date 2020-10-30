----- TRACKING
SELECT CT.SYS_CHANGE_VERSION, 
  CT.SYS_CHANGE_OPERATION, US.Usuario,US.Email 
  FROM CHANGETABLE 
(CHANGES dbo.Usuarios, 0) as CT 
JOIN dbo.Usuarios US
ON CT.Usuario = US.Usuario
ORDER BY SYS_CHANGE_VERSION;


----- DV
select * from Usuarios;
--
--update Usuarios set Nombre = 'Paula' where Usuario = 'PAULA' ; 
--update Usuarios set Nombre = 'Paula Anabel' where Usuario = 'PAULA' ; 


select * from Configuracion;-- Where Clave = 'DVV'
--
--update Configuracion
--set Value = '4118'
--where Clave = 'DVV' ; 