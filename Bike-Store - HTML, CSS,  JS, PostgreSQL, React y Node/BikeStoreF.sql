PGDMP     2    ;    
            {         
   BikeStoreF    15.3    15.3                0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false                       0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false                       0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false                       1262    16456 
   BikeStoreF    DATABASE        CREATE DATABASE "BikeStoreF" WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE_PROVIDER = libc LOCALE = 'Spanish_Spain.1252';
    DROP DATABASE "BikeStoreF";
                postgres    false                        2615    2200    public    SCHEMA     2   -- *not* creating schema, since initdb creates it
 2   -- *not* dropping schema, since initdb creates it
                postgres    false                       0    0    SCHEMA public    ACL     Q   REVOKE USAGE ON SCHEMA public FROM PUBLIC;
GRANT ALL ON SCHEMA public TO PUBLIC;
                   postgres    false    5            �            1259    16484    Venta    TABLE       CREATE TABLE public."Venta" (
    "idVenta" integer NOT NULL,
    productos text[] NOT NULL,
    "cantidaProductos" integer NOT NULL,
    total integer NOT NULL,
    date character varying NOT NULL,
    cliente character varying NOT NULL,
    cantidad integer[] NOT NULL
);
    DROP TABLE public."Venta";
       public         heap    postgres    false    5            �            1259    16483    Venta_idVenta_seq    SEQUENCE     �   CREATE SEQUENCE public."Venta_idVenta_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 *   DROP SEQUENCE public."Venta_idVenta_seq";
       public          postgres    false    221    5                       0    0    Venta_idVenta_seq    SEQUENCE OWNED BY     M   ALTER SEQUENCE public."Venta_idVenta_seq" OWNED BY public."Venta"."idVenta";
          public          postgres    false    220            �            1259    16475    formulario_Envio    TABLE       CREATE TABLE public."formulario_Envio" (
    "idCompra" integer NOT NULL,
    departamento character varying NOT NULL,
    ciudad character varying NOT NULL,
    direccion character varying NOT NULL,
    telefono numeric NOT NULL,
    descripcion character varying NOT NULL
);
 &   DROP TABLE public."formulario_Envio";
       public         heap    postgres    false    5            �            1259    16474    formulario_Envio_idCompra_seq    SEQUENCE     �   CREATE SEQUENCE public."formulario_Envio_idCompra_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 6   DROP SEQUENCE public."formulario_Envio_idCompra_seq";
       public          postgres    false    219    5                       0    0    formulario_Envio_idCompra_seq    SEQUENCE OWNED BY     e   ALTER SEQUENCE public."formulario_Envio_idCompra_seq" OWNED BY public."formulario_Envio"."idCompra";
          public          postgres    false    218            �            1259    16457    productos_idproducto_seq    SEQUENCE     �   CREATE SEQUENCE public.productos_idproducto_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 /   DROP SEQUENCE public.productos_idproducto_seq;
       public          postgres    false    5            �            1259    16458 	   productos    TABLE     �  CREATE TABLE public.productos (
    idproducto integer DEFAULT nextval('public.productos_idproducto_seq'::regclass) NOT NULL,
    marca character varying(20) NOT NULL,
    nombre character varying(50) NOT NULL,
    precio integer NOT NULL,
    tipo character varying(25) NOT NULL,
    color character varying(25) NOT NULL,
    talla character varying(5) NOT NULL,
    descripcion character varying(1000) NOT NULL,
    imagen character varying(200) NOT NULL,
    stock integer NOT NULL
);
    DROP TABLE public.productos;
       public         heap    postgres    false    214    5            �            1259    16464    usuarios_idusuario_seq    SEQUENCE        CREATE SEQUENCE public.usuarios_idusuario_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 -   DROP SEQUENCE public.usuarios_idusuario_seq;
       public          postgres    false    5            �            1259    16465    usuarios    TABLE     �   CREATE TABLE public.usuarios (
    idusuario integer DEFAULT nextval('public.usuarios_idusuario_seq'::regclass) NOT NULL,
    username character varying(25),
    email character varying(25),
    password character varying(25)
);
    DROP TABLE public.usuarios;
       public         heap    postgres    false    216    5            w           2604    16487    Venta idVenta    DEFAULT     t   ALTER TABLE ONLY public."Venta" ALTER COLUMN "idVenta" SET DEFAULT nextval('public."Venta_idVenta_seq"'::regclass);
 @   ALTER TABLE public."Venta" ALTER COLUMN "idVenta" DROP DEFAULT;
       public          postgres    false    220    221    221            v           2604    16478    formulario_Envio idCompra    DEFAULT     �   ALTER TABLE ONLY public."formulario_Envio" ALTER COLUMN "idCompra" SET DEFAULT nextval('public."formulario_Envio_idCompra_seq"'::regclass);
 L   ALTER TABLE public."formulario_Envio" ALTER COLUMN "idCompra" DROP DEFAULT;
       public          postgres    false    219    218    219                      0    16484    Venta 
   TABLE DATA           k   COPY public."Venta" ("idVenta", productos, "cantidaProductos", total, date, cliente, cantidad) FROM stdin;
    public          postgres    false    221   .#                 0    16475    formulario_Envio 
   TABLE DATA           p   COPY public."formulario_Envio" ("idCompra", departamento, ciudad, direccion, telefono, descripcion) FROM stdin;
    public          postgres    false    219    $                 0    16458 	   productos 
   TABLE DATA           v   COPY public.productos (idproducto, marca, nombre, precio, tipo, color, talla, descripcion, imagen, stock) FROM stdin;
    public          postgres    false    215   �$                 0    16465    usuarios 
   TABLE DATA           H   COPY public.usuarios (idusuario, username, email, password) FROM stdin;
    public          postgres    false    217   �:                  0    0    Venta_idVenta_seq    SEQUENCE SET     B   SELECT pg_catalog.setval('public."Venta_idVenta_seq"', 16, true);
          public          postgres    false    220                        0    0    formulario_Envio_idCompra_seq    SEQUENCE SET     N   SELECT pg_catalog.setval('public."formulario_Envio_idCompra_seq"', 16, true);
          public          postgres    false    218            !           0    0    productos_idproducto_seq    SEQUENCE SET     G   SELECT pg_catalog.setval('public.productos_idproducto_seq', 34, true);
          public          postgres    false    214            "           0    0    usuarios_idusuario_seq    SEQUENCE SET     D   SELECT pg_catalog.setval('public.usuarios_idusuario_seq', 6, true);
          public          postgres    false    216                       2606    16491    Venta Venta_pkey 
   CONSTRAINT     Y   ALTER TABLE ONLY public."Venta"
    ADD CONSTRAINT "Venta_pkey" PRIMARY KEY ("idVenta");
 >   ALTER TABLE ONLY public."Venta" DROP CONSTRAINT "Venta_pkey";
       public            postgres    false    221            }           2606    16482 &   formulario_Envio formulario_Envio_pkey 
   CONSTRAINT     p   ALTER TABLE ONLY public."formulario_Envio"
    ADD CONSTRAINT "formulario_Envio_pkey" PRIMARY KEY ("idCompra");
 T   ALTER TABLE ONLY public."formulario_Envio" DROP CONSTRAINT "formulario_Envio_pkey";
       public            postgres    false    219            y           2606    16470    productos productos_pkey 
   CONSTRAINT     ^   ALTER TABLE ONLY public.productos
    ADD CONSTRAINT productos_pkey PRIMARY KEY (idproducto);
 B   ALTER TABLE ONLY public.productos DROP CONSTRAINT productos_pkey;
       public            postgres    false    215            {           2606    16472    usuarios usuarios_pkey 
   CONSTRAINT     [   ALTER TABLE ONLY public.usuarios
    ADD CONSTRAINT usuarios_pkey PRIMARY KEY (idusuario);
 @   ALTER TABLE ONLY public.usuarios DROP CONSTRAINT usuarios_pkey;
       public            postgres    false    217               �   x��ҽj�0�Yz
=�	�ײ�)�:5c�Jk�I(t
~��]
)W�������p�ր��B����kH������m����c8���rݿ/���;_�p�5ʿf�\B���\	�%@�	���CP�\�/Bk�=�d�>1u!0n))���YS tL�&����4�0��ap�I��'���8ѿ�PeF�hƭ����6�as�P��ɂj2�+���.��h���         �   x���A
� �����Sm�{�n�d!ش���W��`�Y
�qt@cOO����OTsRhّ�4��CG�����Ʌ	#a�2glGl~X���~~�/����7�}��LCH�Vڜ�%�0�2O@V��AU߽���G'��U!����=�iV�zB|�P�k            x��[�v#Ir���H�%�AV��c=6���Z�㐜rUI0ɪJl=�D[2��#d��5��3޺4��%��Y����8C �Ȍ�q�Fd�|tU���Ϗ*V��J�E:��v���Dg��j�Ԩ����zt�����ZS���ja�d������EiS�LY=}�m��
�Ex����S�+�Mi
Wї)��_�j�V��mm�w]*�)[T�.��Z��Ĕx�Jt��n�tSЍ&SIfs�
G�+V�Xju��-��T}6�I���.��F��U���t�K܄Z]Z��*��*s<GW��&_9�,ubu��F%�NK�2�4�vq�5�-p�q�����҉��`��%0H
S�%�<�2�MM�Ļ+�z��O�V����3��^���"3�-�Y��,�5��v��t�*�]U��vl��y|Q�cw�{���tU,G���P�A��0���L�;���hv4�^�+`����&S���)�8��G��a7O%��+���y��0Kj��o��s��.��^����22Y-ׅ�s=�໢��K}Nd9���탆���P+�ܺ���kLf�~���jB��:q+8ە�}�.WƤb�F?د�1��B�j�R<�<7QzkSx�ɰ)r'a�df��� V��sە-u�-|%[�����j9�������j��9ލ�EG����7=�pwpѹ��_ۋM�@S����.%ጕ�x��~5����)��`�{ɚ)��������_�����﫦Z���O���E���򜮁�\	ƀ��h#Z*�r�J�/�G�h |�Yg+88%�25�P�y�n��h`~Y����m�������XZ&=j�T��֌b�R�a$�M�����9��Z�+����2�Fjnɽq�ζ�H��B,��x ���|�w��F'}`���F�<�kn���d��lH����@\���|�]w�;t�S��Pwō�؟��"i9iF����1焖}@c}6!36�B��%����Q�J�U 3x�B�c�]�w	m�@�.tr+�X�,S��[�p�qa� �-����9������7}�%��R��F��ݡ�8�
�n\�hN<��$Т�I�,�������R��=ڟK�O!Su��`�,,���!��u�?=Q[�(�v	E��:e��	��Q����֕��z��˒|N$�	�\�W���m���w,�TS���=���r+ �i�G}��� L!�q&<Ժ���B���E�X	9 �ۂR���c3H�L�\�,ZRoFX��X���r�	q��!��uP:x\.���b��e�_�1D�>p�;?�iXq%�`�
@��:�_�f	F����G�d9pukTw�?��p�?Ѣ���ܗ��Rڜ������S� +{o~���$p�sWi���w�ˣ�2���ݍ+sM����:䂖��*��e�E
2)|��F؁���%� R ��bBQ�M��DŖ�Ҡg��$1�I
���'�VcM��_����^�lE�� $��E�(�w{Z��K�K�����^��']b[���G�3b�5"��֐,.J�]����L� ��@�|��X�oC�t ��s�lz�(�GW��i`�`��`w]I6�W�V��ec)�:f�h7�b׿��E4��'tsA�\��߂u�G
z�N�?�O�2$���˜�Kd58����5z��n?������oO�-�0���n���R'X4mh���-��I���/�f�}���<-f���%��3a�%^b��Z�11��(%G��p9et3a���*��W.�D<J&`g��uPL�ÄP�����$�T
�q;RPq@�:�`h�N���Y�[��r]&��~N#$&���(ezp��� ���<V�ޑqn�6,%o�C�2K�I�w��v:ۇ��m�c�ht���j%�NI��͒��59Y��(�E}�k�
O����tr���D5b�b�̣]X)��]��p(��aRFL���^S�o^�ur
��*���=�NyM�L
��*�����`�\Z4^��s��ЗK�ov}����ў���[�vq9�v7E\�@ރ��-�W���.DY)��䪯��N	
ͯJ����©F�)|���+�F���K�3Ŵh�Pဇ���g+��i�4|*w�2���Ҍh8z�3�/��qn��6�mH��vz��T�#(�5�Z4�,i��I^�?�f�E�8�����h:�����l<�!Fui��ls}I�h@&B�"����ʡ�H�l�R%���Za#�`����7�11(��il�W�a�" 
Y���	"����r^��.KXJ���ŘI� ��V������ƑoT��.�LW�:�2W���0�7�E��|�s�:���wy����D&�8*6'{��҃t���l���S�!�&��z>��%e�9��W��}��9��ݲ�uz+!Q��Y&�l�F HS"�׊�]�׊J��I23Uǩ��Ohw�Ei�:%����,�������N�$TAm���"�g\ͤ���7�4�,e75Y�$DK��Wϓ������ȭ�?r�F��\ �G���١�i��O��]�J{{��3*�D"m�J���R�Y[�(�p;n�h'5rE��'�ɕr)�L�R�r7�wLK�tc�N��$zB9�H�H>�"��p�!��/2�����;�a[���=��O���5�o�%Xeg�5��z���7���I�����q�;�Wn�~n�t�"���������͖jۻ�hH��λ�u$m���F%iE�n���_m��q��R��+��t���܂��T�Ѣ�|k�OHr:p �P�?Ws\9�D���k~$i;;߰��
ŷ�>�/(��5%ܽ��,��YK��/���M�%�&1Kk����!E߇�6-÷Dp�5-3�Of�Iﭫ�[n�P�.�����z�=����Ǳo���tzbV5�����?8�ǝ����E��|*֏�㎘�MƩQ:��˗M�>D�ԖZ����L��i�e�!oz��K���/��⣼�YrHR�ȄO��g��ޫc[�P�*m�.�h�R�X����������uT��s��FԬ�����}MԿv��y7LP����W�Bd���ԗ��ު��<�������jR�	\�3�+ݼ��>	罇=��ڤT��7-��bIQ�o�Y���a��mۧ�E����/;ݵb�k1�l03t\�-D�aQ�c<�}7��~mԇ�Δ|z@��Q.;��rږ�h����VR����Wʲ�&��1>����T7�Ĳ�N{�_ -�����/A����	�������~#�R�=�T����b"��d�N7i�W�p&�Tt�;Hw�pWJ�{��A��+�##m�\X��«�q������|_� �m&�Q��#Zj ��"�=c��)��?����?��!����� nS��a�I�y�{u���=�$�8Ҧ��g�\^^LT|0��|��x�u��/�� f���n���mp�^�,��1��K��ⷆGD���A�Go��ßT}[��/������G�LO�T$�26N��2���<i�wk�[�6���1�Ʊo$]�9�#5��b���lE)�m�����K,����0�J�F� z���������+q;�^W�l��k(3ˍJ�=��0	��@����������Xtd�&�Mے���vT�emEFG5��2��g����H��-���ͽ���7�o;�6��URȆEuF�[m�Z��-�<�IZ��Dc�h��Y����5�8E�H���ʄ��)W ��ϴ@��G�C$��u�ɮ,��az�O��ԙ(��O(H]�r��?�lPB��kW�}�\$E�|d�Ə!����dNy��z9u�
�&g�̩�����?p������_2��zd�J&����u����hJ�
��{F�����^��P���vy[��πld=[��[�(Fq� ������m䄲t7�T��&�V����ޤ[�(¾�QOӯ��n59E�65�����D��z����t`�0���p'�����X�35� �8���Vʦ^Js�� o���� �  a4�e�& Q��h(%�w:�`�7�10��,;��_�x|��dA^6dF�N9��\ߺ�p�#:B����b
��?�Ϟr��O^��h�r-П�h�&+y�q��+�x�S��0��W C!�´���x��(�}/�`�9L�S]�	�g��I�A���'���ǓO��y|䡇�jQ~� =<8�# ��ݟ
MJD&K��Z~��g�O����� ��A+���ck!��<w���}�N=��w����.h�ͷ](�'8/]����. Z���Ż�Cۈ�4JaAI��%~�L���閣q��+������z�|.!X���"I^q4%J�� Z��fA�������w��8��f��)K��鯏V�� ��6�k�TO���9[��z�m:J���{���!ZS>�Lh�P��&ۊ�?_|�|vޱr�K_{�Y���"X}�V����ӏ$�~�,��r�kX r(OڮV{h<�*���;��I�G# ����ğ��@ڛ����i�!ow���e��{Ȏ�&�P/<�v�I��DKxv�U�]�JBvp�,��%&�#ጰ)��A&�����m	L�f���=0�h�nЫI��4T�/*W.g=��֥���=�Vh�/�r��O8�Gx��cl)�E�'[V���T��Ρ�aqe���0$�������>�2<��Z&��r�gp���"��ָ�����T�\��ْ�8^)#fd�0�*�!�Ќ:���ܤ�O�PmQl�]|I>��g��+��rW���r��ã�yE�'��}	�P�1�<���'cz�*��	ެ(��{�6��mPpѰ[����	/�m!�����z6� �����K��� ��s�h�5tT�y��`��x;��}O����C����)�O�.�{%_�:�����x.n���oM9�p.��`.~� ��'���;�-��3&�3���*�h+ar��M�2n���uWU��(�G'�4�9����Mh�L�7���3�	�ż�������,RuQ�|!�w�f_��/R�?���4������ڕT�y�dx=t_�&T2o6^������xQ~�:��K�@f��j���D���'b�	�Vt���MV	`^E[CK����t �[�t���$O��:���t=�)��{������n%�6�t���z����ߴ���1:�z�@�2�o�|68v:��P�zi�OB�����4;F}�cja0�_���r}=�����0�+�+�|,OBL�d�dI�YEC9Bm=��	����n��N-ȍ�Q�5ԠJ�d�^�vs�a��]t}�\0���k���s���ӻ�A��g3�X��5���K����%��ˁڛ�����MY��^=�멞A-�������He��)�(�����tHK[��1�9G���͠J������;�H/l�Q��`ˢ
�:�x���ߧ���� ���f         z   x�M�;�0D���DJ���DC'��|�va*N�Y)��Ho��k=�P�A�0V�og�m�t.K�G�΋5���Y��j��2�2�Q��뭆�jS�lp8�O0&�����Mr�D��(4     