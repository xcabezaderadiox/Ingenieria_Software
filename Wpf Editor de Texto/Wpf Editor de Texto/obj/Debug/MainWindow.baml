   M S B A M L   `   `   `  ����N  JWpf Editor de Texto, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:Wpf_Editor_de_TextoWpf_Editor_de_Texto  5   	   $    Wpf_Editor_de_Texto.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:Wpf_Editor_de_Texto     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � RowDefinitions 5
   
   �� 5      $	��18* �6   �� 5      $
��175* �6   �� 5      $	��17* �6   .+�5   
   c� .@�5      �� -   5         � ToolTip$ Mostrar Texto��5      .��5      �� $��Iconos/escudovelez.jpg��6   5      �� 5      -   5        $ Abrir Archivo��5      .��5      �� $��Iconos/chila.jpg��6   5      �� 5      -   5        $ Guardar Archivo��5      .��5      �� $��Iconos/Asad.jpg��6   5      �� 5      -   5        $��boton��5   F   $ Guardar Editado��6   {�.  .��5      �� $��Iconos/velez.jpg��6   5      �� 5      -   5        $ Guardar Como��5      .��5      �� $��Iconos/velez.jpg��6   5      5      �� 5    
   -   5        $��	txteditor��5       $��1��6#   $��5q�60   
����  � �� AcceptsReturn .  �� 
AcceptsTab . 6   5!      5"      