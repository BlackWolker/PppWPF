   M S B A M L   `   `   `  ����B  >PPE.Wpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:PPE.Wpf.ViewModelsPPE.Wpf.ViewModels  5          PPE.Wpf.View.UserView   5      W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      c _MahApps.Metro.IconPacks.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Material, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137a:Icon-http://metro.mahapps.com/winfx/xaml/iconpacks   5      Fmc;http://schemas.openxmlformats.org/markup-compatibility/2006   5      <d2http://schemas.microsoft.com/expression/blend/2008   5      3
viewmodels clr-namespace:PPE.Wpf.ViewModels   5      
�������.��5      � $��1��6   $��30 20 20 20q�6     � RowDefinitions  5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $
��auto �6   .+�5   
   �� $��Utilisateurs��6   $��1��6(   $��32(�65   $��SemiBold"�6C   $��0 20 0 0q�6Y   $
��Left=�6k   ���#1215186�   �� 5   
   -   5           	addButton#��[  5      .��5      ��  �� Orientation$ 
Horizontal=�6   .+�5      .  (MahApps.Metro.IconPacks.PackIconMaterial     Kind$
 Plus=�6(   $��Center=�64   $��11��6O   $��11��6Z   $��0 1 8 0q�6f   �� 5      $��Ajouter une donnée��6   5      5       �� 5#   
   $��1��6   ���#dae2ea$��
0,51,0,180q�64   $��4��6H   $��2��6U   �� 5&   
   $��2��6   $ 
Horizontal=�6"   $��0 10 0 0q�6;   .+�5'      �� $�� ��6     	tabButton#��[ 6!   ���#784ff26D   5)      �� 5,   
   $��Worktogether��6   $��4��6(   $��18(�65   $��SemiBold"�6C   ���#121518$
��Left=�6n   $��Center=�6�   �� 5.   
   $��Filtre��6   $��4��6"   $��13(�6/   $��SemiBold"�6=   $��	0 0 215 0q�6S   ���#121518$��Right=�6{   $��Center=�6�   � 51   
   $	��200��6   $��Right=�6   $��4��67   .+�52      �� $
��15 0q�6   $��Center=�6&   ���#b0b9c6 J� IsHitTestVisible$ False��6V    K� ZIndex$ 1��6o   $��Chercher une donnée...��6�   �� 53      -   5         ��Name$ 
textFilter��53       
 Filter#��[ 6*   54      &   System.Windows.Controls.DataGrid  57   
      AutoGenerateColumns$ False��6W   $��1��6s     DataGridStyle1#���  6�     DataGridCellStyle1   	CellStyle# �  6�     DataGridColumnHeaderStyle1   ColumnHeaderStyle# �  6�     DataGridRowStyle1	   RowStyle#	 �  6  $��5��6N  ��6   �� *Users+
 �� SelectedItem
 61   �� *SelectedUser+   Columns 58      4  .System.Windows.Controls.DataGridCheckBoxColumn  59      ,  &System.Windows.Controls.DataGridColumn   CanUserResize$ False��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$
 auto 6?     CheckBoxStyle11  +System.Windows.Controls.DataGridBoundColumn   ElementStyle# [ 6L      HeaderTemplate 5:      �� 5;      .R�5<      �� #��[ 6'   5=      5?      0  *System.Windows.Controls.DataGridTextColumn  5A         Header$ Identifiant��6%      
IsReadOnly$
 True��6:   $ False��6L   $
 auto 6b      Binding 6o   �� *Id+  5C      $	 Nom��6%   $
 True��62   $ * 6D    6N   �� *
LastName+  5D      $ Prénom��6%   $
 True��65   $ * 6G    6Q   �� *	FirstName+  5E      $ Adresse��6%   $
 True��66   $ * 6H    6R   �� *
Addresse+4  .System.Windows.Controls.DataGridTemplateColumn  5G      $ Opérations��6)   $
 True��6=   $
 auto 6O      CellTemplate 5H      �� 5I      .R�5J      �� $ 
Horizontal=�6)   .+�5K   "   ��   gridEditButton#��[ 6)   .��5L   &     $ PencilOutline=�6<    	 gridButtonIcon#��[	 6Q   5M   #   �� 5N   "   -   5         
 gridRemoveButton#��[
 5N   )   $��5 0 0 0q�6k   .��5O   &     $ DeleteOutline=�6<   #��[	 6Q   5P   #   5Q      5R      5T      5W      5X      5Y      