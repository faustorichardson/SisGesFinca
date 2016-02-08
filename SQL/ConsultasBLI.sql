-- CONSULTA DE COSECHA
SELECT 
	idcosecha as ID, fechacorte as Fecha, semana as Semana, campo as Campo, 
	cinta_verde as Verde, cinta_azul as Azul, cinta_amarilla as Amarilla, 
	cinta_marron as Marron, cinta_gris as Gris, cinta_roja as Roja, 
	cinta_blanca as Blanca, cinta_negra as Negra, cantidadtotal as CantidadTotal,
	cantidadrechazos as CantidadRechazos
FROM
	cosecha
WHERE
	1=1 AND semana ='1';


-- CONSULTA DE SUBCATEGORIAS
SELECT 
	subcategorias.id as Id, 
	subcategorias.descripcion as Descripcion, 
	categorias.descripcion as Categoria
FROM 
	subcategorias
INNER JOIN categorias ON subcategorias.categoria = categorias.id                    
WHERE 1=1
ORDER BY subcategorias.descripcion ASC;

-- INSERTAR CALENDARIO DESDE EXCEL
-- insert into 
-- calendarioencintado(semana, fechadesde, fechahasta, colorencintado, colorcosecha,
-- sem10, sem11, sem12, sem13)
-- select SEMANA, Del, Al, COLOR_CINTA, F5, F6, F7, F8, F9 from temp


-- CONSULTA DE PRODUCTOS
SELECT 
	productoproductoss.desc_productos as Productos, unidadmedidas.desc_unidad as Medida,
	productos.existencia as Existencia, subcategorias.descripcion as Subcategoria
FROM 
	productos
INNER JOIN subcategorias ON subcategorias.id = productos.subcategoria
INNER JOIN unidadmedidas ON unidadmedidas.id_unidad = productos.medida
WHERE 1=1
