select * from zonas 
select * from precios
select * from drec
select * from Recinto
select * from evento
select * from compra
select * from login 
select * from datos_usuarios
select (nombre+' '+Ap_pater+' '+' '+Ap_mater) as Nombre,DATEDIFF(hour,fechan,GETDATE())/8766 AS Edad,Correo ,usuario from datos_usuarios inner join login on login.id_datos_usuarios=datos_usuarios.id_datos_usuarios
select nombre_recinto ,(Calle+' '+' '+Colonia+' '+' '+Delegacion)as direccion from Recinto inner join drec on Recinto.id_direccion_recinto=drec.id_direccion_recinto
select nombre_evento as Evento ,zonas as Zona_Disponible ,precio,localidades , vendidos from zonas inner join precios on zonas.id_zonas=precios.id_zonas inner join evento on evento.id_precios=precios.id_precios
select nombre_evento,fecha,zonas, precio,nombre_recinto ,capacidad from zonas INNER JOIN precios on zonas.id_zonas = precios.id_zonas inner join Recinto on precios.id_zonas=Recinto.id_recinto inner join evento on evento.id_evento=Recinto.id_recinto
select  nombre_evento ,precio,nombre_recinto ,capacidad,Calle,Colonia,Delegacion, zonas from zonas,precios,drec,Recinto,evento,compra where evento.id_evento=975