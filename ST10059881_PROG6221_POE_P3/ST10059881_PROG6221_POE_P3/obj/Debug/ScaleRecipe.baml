   M S B A M L   `   `   `  ����U  QST10059881_PROG6221_POE_P3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:ST10059881_PROG6221_POE_P3ST10059881_PROG6221_POE_P3  5   	   ,    &ST10059881_PROG6221_POE_P3.ScaleRecipe   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   :local(clr-namespace:ST10059881_PROG6221_POE_P3     5   	     � Title$  ScaleRecipe��5   	   $	��450��6   $	��800��6*   ��5	      �� 5
   
    �� ImageSource$ Resources/roti.jpg��6   .��5      �  � ColumnDefinitions 5   
   �� 5      $��20 �6   �� 5      $��* �6   �� 5      $��20 �6    � RowDefinitions 5   
   �� 5      $��20 �6   �� 5      $��90 �6   �� 5      $	��200 �6   �� 5      $��90 �6   �� 5      $��20 �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ grdScale��5      $��1��6%   $��2��65      AutoGenerateColumns . 6B   �� 5   
   -   5         ��Name$ 	lblRecipe��5      $��1��6#   $ ��Recipe you want to scale: ��63   $
��Left=�6X   $��34,0,0,0q�6s   $��1��6�   $��Center=�6�   $��20(�6�   
��� �|�6�   �� 5   
   -   5        $ 	lblFactor��5      $��1��6#   $��Scaling factor: ��63   $
��Left=�6N   $��	456,0,0,0q�6i   $��1��6|   $��Center=�6�   $��20(�6�   
��� �|�6�   �� 5   
   -   5         ��Name$ btnScale��5      $��1��6#   $��Scale��63   $��Center=�6C   $��0,5,0,0q�6`   $��3��6q   $	��Top=�6~   $��15(�6�   $��80��6�   
����� �6�   �� 5   
   -   5        $ btnMainMenu��5      $��1��6&   $��	Main Menu��66   $��Center=�6J   $��0,60,0,0q�6g   $��3��6y   $	��Top=�6�   $��14(�6�   
���  ��6�   �� 5   
   -   5         ��Name$ cmbRecipeSelect��5      $��1��6,   $
��Left=�6<   $��
292,32,0,0q�6W   $��1��6k   $	��Top=�6x   $	��120��6�   �� 5   
   -   5        $ cmbScale��5      $��1��6%   $
��Left=�65   $��	618,0,0,0q�6P   $��1��6c   $��Center=�6p   $	��120��6�   5       5!      