PGDMP     (                    {         
   BikeStoreF    15.3    15.3     �           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false            �           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false            �           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false            �           1262    16400 
   BikeStoreF    DATABASE     �   CREATE DATABASE "BikeStoreF" WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE_PROVIDER = libc LOCALE = 'Spanish_Colombia.1252';
    DROP DATABASE "BikeStoreF";
                postgres    false            �            1259    16401 	   productos    TABLE     f   CREATE TABLE public.productos (
    idproductos integer NOT NULL,
    nombre character varying(50)
);
    DROP TABLE public.productos;
       public         heap    postgres    false            �          0    16401 	   productos 
   TABLE DATA           8   COPY public.productos (idproductos, nombre) FROM stdin;
    public          postgres    false    214   ]       e           2606    16405    productos productos_pkey 
   CONSTRAINT     _   ALTER TABLE ONLY public.productos
    ADD CONSTRAINT productos_pkey PRIMARY KEY (idproductos);
 B   ALTER TABLE ONLY public.productos DROP CONSTRAINT productos_pkey;
       public            postgres    false    214            �      x�3�L�L�L�I-I�2B���b���� �N�     