   M S B A M L   `   `   `  ����E  AZGAF_EX_3P, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:ZGAF_EX_3P
ZGAF_EX_3P  5   	       ZGAF_EX_3P.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:ZGAF_EX_3P     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � .+�5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dtgMaterias��5
      $
��Left=�6(   $	��224��6C   $��	0,195,0,0q�6P   $	��Top=�6c   $	��792��6{      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ FOLIO��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 64   �� *Folio+  5      $ NOMBRE MATERIA��6%    6=   �� *Nombre+  5      $ DESCRIPCION��6%    6:   �� *Descripcion+  5      $ HORAS SEMANALES��6&    6?   �� *HorasSemana+  5      $ SEMESTRE��6%    67   �� *NumSemestre+  5      $ NOMBRE CARRERA��6&    6>   �� *	Nombre_+  5      $ REGISTRO SEP��6&    6<   �� *RegistroSep+5      �� 5   
   $��Folio��6   $
��Left=�6    $��	34,20,0,0q�6;   $	��Top=�6N   �� 5   
   $��Nombre Materia��6   $
��Left=�6)   $��	34,51,0,0q�6D   $	��Top=�6W   �� 5   
   $��Descripción��6   $
��Left=�6&   $��	34,82,0,0q�6A   $	��Top=�6T   �� 5   
   $��Horas Semanales��6   $
��Left=�6*   $��
34,113,0,0q�6E   $	��Top=�6Y   �� 5   
   $��Semestre��6   $
��Left=�6#   $��
34,144,0,0q�6>   $	��Top=�6R   �� 5   
   -   5         ��Name$ txtFolio��5      $
��Left=�6$   $��23��6?   $��
151,23,0,0q�6K    �� TextWrapping$
 Wrap=�6_   $	��Top=�6s   $	��120��6�    �� 
IsReadOnly . $��0��6�   �� 5   
   -   5        $ 
txtNombreM��5      $
��Left=�6&   $��23��6A   $��
151,54,0,0q�6M   $
 Wrap=�6a   $	��Top=�6u   $	��120��6�   �� 5   
   -   5        $ txtDescripcion��5      $
��Left=�6*   $��23��6E   $��
151,85,0,0q�6Q   $
 Wrap=�6e   $	��Top=�6y   $	��120��6�   �� 5   
   -   5        $ txtHorasSemana��5      $
��Left=�6*   $��23��6E   $��151,116,0,0q�6Q   $
 Wrap=�6f   $	��Top=�6z   $	��120��6�   �� 5   
   -   5        $ txtNumSemestre��5      $
��Left=�6*   $��23��6E   $��151,147,0,0q�6Q   $
 Wrap=�6f   $	��Top=�6z   $	��120��6�   �� 5   
   $��Nombre Carrera��6   $
��Left=�6)   $��
355,20,0,0q�6D   $	��Top=�6X   �� 5    
   $��Registro SEP��6   $
��Left=�6'   $��
355,51,0,0q�6B   $	��Top=�6V   �� 5!   
   -   5        $ 
txtNombreC��5!      $
��Left=�6&   $��23��6A   $��
485,23,0,0q�6M   $
 Wrap=�6a   $	��Top=�6u   $	��120��6�   �� 5"   
   -   5        $ txtRegistroSep��5"      $
��Left=�6*   $��23��6E   $��
485,54,0,0q�6Q   $
 Wrap=�6e   $	��Top=�6y   $	��120��6�   �� 5#   
   -	   5         ��Name$ 	btnUpdate��5#      $��Actualizar
Datos��6$   $
��Left=�6H   $��
707,23,0,0q�6c   $	��Top=�6w   $��75��6�   6�   �� 5$   
   -
   5        $ 
btnRefresh��5$      $��	Refrescar��6%   $
��Left=�69   $��707,170,0,0q�6T   $	��Top=�6i   $��75��6�   6�   5&      5'      