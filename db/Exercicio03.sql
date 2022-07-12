ALTER TABLE ITEM_PRODUTO
ADD (TIPO_MEDIDA VARCHAR(30));

ALTER TABLE ITEM_PRODUTO
ADD CONSTRAINT CK_ITEM_PRODUTO_TIPO_MEDIDA CHECK (TIPO_MEDIDA IN ('LITRO', 'KILO', 'UNIDADE'));

ALTER TABLE MATERIA_PRIMA
DROP CONSTRAINT UK_MATERIA_PRIMA_COD_MATERIA_PRIMA;

DESC USER_CONSTRAINTS;

CREATE SEQUENCE
SEQ_CATEGORIA;

INSERT INTO CATEGORIA(COD_CATEGORIA, CATEGORIA)
VALUES (SEQ_CATEGORIA.NEXTVAL, 'DOCE');

INSERT INTO CATEGORIA(COD_CATEGORIA, CATEGORIA)
VALUES (SEQ_CATEGORIA.NEXTVAL, 'BEBIDA');

INSERT INTO CATEGORIA(COD_CATEGORIA, CATEGORIA)
VALUES (SEQ_CATEGORIA.NEXTVAL, 'CONGELADO');


SELECT * FROM CATEGORIA;