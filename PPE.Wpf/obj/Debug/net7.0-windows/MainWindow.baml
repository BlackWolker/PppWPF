   M S B A M L   `   `   `  ����B  >PPE.Wpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:PPE.WpfPPE.Wpf  5   	   +clr-namespace:PPE.Wpf.ViewPPE.Wpf.View  5   	       PPE.Wpf.MainWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   c _MahApps.Metro.IconPacks.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Material, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137a:Icon-http://metro.mahapps.com/winfx/xaml/iconpacks   5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:PPE.Wpf     5   	   ,viewsclr-namespace:PPE.Wpf.View     5   	     � Title$  
MainWindow��5
   	   $	��720��6   $
��1080��6)    � WindowStartupLocation$ CenterScreen=�66    � WindowStyle$
 None=�6[    � AllowsTransparency$
 True��6n   
������  � 	Resources 5         	BoolToVis��%   &	        �� 5   
   6'   5      .��5      �� -   5        
������� �� CornerRadius$ 30��5       ._�5   
   �  � ColumnDefinitions 5      �� 5      $	��200 �6#   �� 5      $��* �6#   .+�5      �  � RowDefinitions 5      �� 5      $	��124 �6$   �� 5      .+�5      �� $��
28,44,0,50q�6     	topButton#��[ 6-   $��30��6P   .��5      .  (MahApps.Metro.IconPacks.PackIconMaterial     Kind$
 Menu=�6,   $��20��68   $��20��6C   5      �� 5!      $��1��6   ���#623ed0$ 	0 50 0 30��6;   ._�5"      ]� .+�5$      �� $��80��6!   $��80��6,   	 �� Padding$	 3q�68   
�������$	 100��6W   $	��Top=�6j   $
��Left=�6   $��
20 -30 0 0q�6�   ._�5%      A� ��5&   "   �� 5'   &   
 �� ImageSource$
 /Images/logo.png��61   5)      5*      �� 5-      $��Worktogether��6$   
�������$��22(�6K   $��SemiBold"�6Y   $	��Top=�6o    �� TextAlignment$ Center=�6�   $��	5 25 0 10q�6�   �� 5.      $��Gestion d'unité de baies��6$   ���#d0bfff$��14(�6Y   $��SemiBold"�6g   $	��Top=�6}   $ Center=�6�   �� 50      $��25q�6$   $	��Top=�60   $	��0.8��6E   ���#7e5fdc6R   �� 53      $	��Top=�6%   .+�54      �� -   5          DashBoardButton#��[ 54   %   .��55   "   ��  �� Orientation$ 
Horizontal=�6-   .+�56   &     $ HomeVariant=�6<     DashBoardButtonIcon#��[ 6O   �� 57   &   $��Tableau de bord��60   58   #   59      �� 5>      -   5        #��[ 5>   %   .��5?   "   �� $ 
Horizontal=�6-   .+�5@   &     $ AccountMultipleOutline=�6<   #��[ 6Z   �� 5A   &   $��Utilisateurs��60   5B   #   5C      �� 5F      -   5        #��[ 5F   %   .��5G   "   �� $ 
Horizontal=�6-   .+�5H   &     $ StoreOutline=�6<   #��[ 6P   �� 5I   &   $��Réservations��60   5J   #   5K      �� 5N      -   5        #��[ 5N   %   .��5O   "   �� $ 
Horizontal=�6-   .+�5P   &     $ Package=�6<   #��[ 6K   �� 5Q   &   $��Packs��60   5R   #   5S      �� 5V      -   5        #��[ 5V   %   .��5W   "   �� $ 
Horizontal=�6-   .+�5X   &     $ Server=�6<   #��[ 6J   �� 5Y   &   $��Unités��60   5Z   #   5[      �� 5^      -   5        #��[ 5^   %   .��5_   "   �� $ 
Horizontal=�6-   .+�5`   &     $ Babel=�6<   #��[ 6I   �� 5a   &   $��Baies��60   5b   #   5c      �� 5e      #��[ 6%   .��5f   "   �� $ 
Horizontal=�6-   .+�5g   &     $ Tools=�6<   #��[ 6I   �� 5h   &   $��Option��60   5i   #   5j      5l      �� 5n      #��[ 6!   $��Bottom=�6J   $��Bottom=�6e   $
��15 0q�6}   .��5o      �� $ 
Horizontal=�6)   .+�5p   "     $ Logout=�68   #��[ 6F   �� 5q   "   $��Déconnexion��6,   5r      5s      5v      5w      5x      � 5{      $��1��6   $��30 20 20 20q�6#    5|      �� 5}      $
��auto �6$   �� 5~      $
��auto �6$   �� 5      $
��auto �6$   �� 5�      $
��auto �6$   �� 5�      $
��auto �6$   �� 5�      $��* �6$   �� 5�      $
��auto �6$   .+�5�      � $	��300��6   $
��Left=�6#   .+�5�      �� $
��20 0q�6    $��Center=�6.   ���#b0b9c6 J� IsHitTestVisible$ False��6^    K� ZIndex$ 1��6w   $��Chercher ici ...��6�   y�6�   ��  �� ElementName$ 
textSearch�� �� Path$ Text.IsEmpty� �� 	Converter# [  �� 5�      -   5         ��Name$ 
textSearch��5�       
 Search#��[ 62     5�      $ Magnify=�6,   $��15��6;   $��15��6F   $��Center=�6R   $��0 0 15 0q�6m   ���#b0b9c6$��Right=�6�   5�      �� 5�      -	   5        #��[ 5�      $��0 0 20 0q�6<   $��Right=�6N   .��5�        $ Close=�6,   5�      �� 5�      #��[ 6   $��0 0 55 0q�6<   ���#dcdcdc$��Right=�6c   .��5�        $	 Cog=�6,   5�      �� 5�      #��[ 6   $��0 0 85 0q�6<   $��Right=�6N   .��5�        $ 	BellAlert=�6,   5�      �� 5�      $��1��6   ���#dae2ea$��
0,42,0,579q�6<   $��5��6P   ]� 5�      -
   5         ]�Name$ 	DockPanel��5�      $��0,115,0,115q�6/   $��6��6D   .+�5�         PPE.Wpf.View.AccueilView  $	��494��6(   5�      5�      5�      5�      5�      