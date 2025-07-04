PGDMP  :                    }            MieQueue    17.4    17.4 $    A           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                           false            B           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                           false            C           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                           false            D           1262    34062    MieQueue    DATABASE     p   CREATE DATABASE "MieQueue" WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE_PROVIDER = libc LOCALE = 'en-US';
    DROP DATABASE "MieQueue";
                     postgres    false            �            1259    34063    detail_transaksi    TABLE       CREATE TABLE public.detail_transaksi (
    id_detail integer NOT NULL,
    id_transaksi integer,
    id_menu integer,
    jumlah integer,
    subtotal numeric(10,0),
    harga integer,
    status character varying(20),
    nama_pelanggan character varying(50)
);
 $   DROP TABLE public.detail_transaksi;
       public         heap r       postgres    false            �            1259    34066    detail_transaksi_id_detail_seq    SEQUENCE     �   CREATE SEQUENCE public.detail_transaksi_id_detail_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 5   DROP SEQUENCE public.detail_transaksi_id_detail_seq;
       public               postgres    false    217            E           0    0    detail_transaksi_id_detail_seq    SEQUENCE OWNED BY     a   ALTER SEQUENCE public.detail_transaksi_id_detail_seq OWNED BY public.detail_transaksi.id_detail;
          public               postgres    false    218            �            1259    34067    menus    TABLE     z   CREATE TABLE public.menus (
    id_menu integer NOT NULL,
    nama_menu character varying(50),
    harga numeric(10,0)
);
    DROP TABLE public.menus;
       public         heap r       postgres    false            �            1259    34070    menus_id_menu_seq    SEQUENCE     �   CREATE SEQUENCE public.menus_id_menu_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 (   DROP SEQUENCE public.menus_id_menu_seq;
       public               postgres    false    219            F           0    0    menus_id_menu_seq    SEQUENCE OWNED BY     G   ALTER SEQUENCE public.menus_id_menu_seq OWNED BY public.menus.id_menu;
          public               postgres    false    220            �            1259    34071 	   transaksi    TABLE     �   CREATE TABLE public.transaksi (
    id_transaksi integer NOT NULL,
    tanggal_transaksi date,
    total numeric(10,0),
    nama_pelanggan character varying(50)
);
    DROP TABLE public.transaksi;
       public         heap r       postgres    false            �            1259    34074    transaksi_id_transaksi_seq    SEQUENCE     �   CREATE SEQUENCE public.transaksi_id_transaksi_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 1   DROP SEQUENCE public.transaksi_id_transaksi_seq;
       public               postgres    false    221            G           0    0    transaksi_id_transaksi_seq    SEQUENCE OWNED BY     Y   ALTER SEQUENCE public.transaksi_id_transaksi_seq OWNED BY public.transaksi.id_transaksi;
          public               postgres    false    222            �            1259    34075    users    TABLE     �   CREATE TABLE public.users (
    id_user integer NOT NULL,
    username character varying(20),
    password character varying(20)
);
    DROP TABLE public.users;
       public         heap r       postgres    false            �            1259    34078    users_id_user_seq    SEQUENCE     �   CREATE SEQUENCE public.users_id_user_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 (   DROP SEQUENCE public.users_id_user_seq;
       public               postgres    false    223            H           0    0    users_id_user_seq    SEQUENCE OWNED BY     G   ALTER SEQUENCE public.users_id_user_seq OWNED BY public.users.id_user;
          public               postgres    false    224            �           2604    34079    detail_transaksi id_detail    DEFAULT     �   ALTER TABLE ONLY public.detail_transaksi ALTER COLUMN id_detail SET DEFAULT nextval('public.detail_transaksi_id_detail_seq'::regclass);
 I   ALTER TABLE public.detail_transaksi ALTER COLUMN id_detail DROP DEFAULT;
       public               postgres    false    218    217            �           2604    34080    menus id_menu    DEFAULT     n   ALTER TABLE ONLY public.menus ALTER COLUMN id_menu SET DEFAULT nextval('public.menus_id_menu_seq'::regclass);
 <   ALTER TABLE public.menus ALTER COLUMN id_menu DROP DEFAULT;
       public               postgres    false    220    219            �           2604    34081    transaksi id_transaksi    DEFAULT     �   ALTER TABLE ONLY public.transaksi ALTER COLUMN id_transaksi SET DEFAULT nextval('public.transaksi_id_transaksi_seq'::regclass);
 E   ALTER TABLE public.transaksi ALTER COLUMN id_transaksi DROP DEFAULT;
       public               postgres    false    222    221            �           2604    34082    users id_user    DEFAULT     n   ALTER TABLE ONLY public.users ALTER COLUMN id_user SET DEFAULT nextval('public.users_id_user_seq'::regclass);
 <   ALTER TABLE public.users ALTER COLUMN id_user DROP DEFAULT;
       public               postgres    false    224    223            7          0    34063    detail_transaksi 
   TABLE DATA           }   COPY public.detail_transaksi (id_detail, id_transaksi, id_menu, jumlah, subtotal, harga, status, nama_pelanggan) FROM stdin;
    public               postgres    false    217   �)       9          0    34067    menus 
   TABLE DATA           :   COPY public.menus (id_menu, nama_menu, harga) FROM stdin;
    public               postgres    false    219   *       ;          0    34071 	   transaksi 
   TABLE DATA           [   COPY public.transaksi (id_transaksi, tanggal_transaksi, total, nama_pelanggan) FROM stdin;
    public               postgres    false    221   �*       =          0    34075    users 
   TABLE DATA           <   COPY public.users (id_user, username, password) FROM stdin;
    public               postgres    false    223   �*       I           0    0    detail_transaksi_id_detail_seq    SEQUENCE SET     M   SELECT pg_catalog.setval('public.detail_transaksi_id_detail_seq', 1, false);
          public               postgres    false    218            J           0    0    menus_id_menu_seq    SEQUENCE SET     @   SELECT pg_catalog.setval('public.menus_id_menu_seq', 15, true);
          public               postgres    false    220            K           0    0    transaksi_id_transaksi_seq    SEQUENCE SET     I   SELECT pg_catalog.setval('public.transaksi_id_transaksi_seq', 1, false);
          public               postgres    false    222            L           0    0    users_id_user_seq    SEQUENCE SET     ?   SELECT pg_catalog.setval('public.users_id_user_seq', 1, true);
          public               postgres    false    224            �           2606    34084 &   detail_transaksi detail_transaksi_pkey 
   CONSTRAINT     k   ALTER TABLE ONLY public.detail_transaksi
    ADD CONSTRAINT detail_transaksi_pkey PRIMARY KEY (id_detail);
 P   ALTER TABLE ONLY public.detail_transaksi DROP CONSTRAINT detail_transaksi_pkey;
       public                 postgres    false    217            �           2606    34086    users id_user_pkey 
   CONSTRAINT     U   ALTER TABLE ONLY public.users
    ADD CONSTRAINT id_user_pkey PRIMARY KEY (id_user);
 <   ALTER TABLE ONLY public.users DROP CONSTRAINT id_user_pkey;
       public                 postgres    false    223            �           2606    34088    menus menus_pkey 
   CONSTRAINT     S   ALTER TABLE ONLY public.menus
    ADD CONSTRAINT menus_pkey PRIMARY KEY (id_menu);
 :   ALTER TABLE ONLY public.menus DROP CONSTRAINT menus_pkey;
       public                 postgres    false    219            �           2606    34090    transaksi transaksi_pkey 
   CONSTRAINT     `   ALTER TABLE ONLY public.transaksi
    ADD CONSTRAINT transaksi_pkey PRIMARY KEY (id_transaksi);
 B   ALTER TABLE ONLY public.transaksi DROP CONSTRAINT transaksi_pkey;
       public                 postgres    false    221            �           2606    34092    users unique_username 
   CONSTRAINT     T   ALTER TABLE ONLY public.users
    ADD CONSTRAINT unique_username UNIQUE (username);
 ?   ALTER TABLE ONLY public.users DROP CONSTRAINT unique_username;
       public                 postgres    false    223            �           2606    34093 .   detail_transaksi detail_transaksi_id_menu_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.detail_transaksi
    ADD CONSTRAINT detail_transaksi_id_menu_fkey FOREIGN KEY (id_menu) REFERENCES public.menus(id_menu) NOT VALID;
 X   ALTER TABLE ONLY public.detail_transaksi DROP CONSTRAINT detail_transaksi_id_menu_fkey;
       public               postgres    false    217    4764    219            �           2606    34098 3   detail_transaksi detail_transaksi_id_transaksi_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.detail_transaksi
    ADD CONSTRAINT detail_transaksi_id_transaksi_fkey FOREIGN KEY (id_transaksi) REFERENCES public.transaksi(id_transaksi) ON DELETE CASCADE;
 ]   ALTER TABLE ONLY public.detail_transaksi DROP CONSTRAINT detail_transaksi_id_transaksi_fkey;
       public               postgres    false    217    4766    221            �           2606    34103 $   detail_transaksi fk_detail_transaksi    FK CONSTRAINT     �   ALTER TABLE ONLY public.detail_transaksi
    ADD CONSTRAINT fk_detail_transaksi FOREIGN KEY (id_transaksi) REFERENCES public.transaksi(id_transaksi);
 N   ALTER TABLE ONLY public.detail_transaksi DROP CONSTRAINT fk_detail_transaksi;
       public               postgres    false    221    4766    217            7      x������ � �      9   �   x�Uν�0����*��@��	'G�34��@�'����.���/'���&����8�L���B�H
��Wi���D�T� ��C���!�
�޸�y��4�m�3�c?v�5��rN�ڄfB�����\�m?�ʿ^{�l��%�R�g"y�.�%��������=�      ;      x������ � �      =      x�3�tL��̃��F�\1z\\\ E�^     