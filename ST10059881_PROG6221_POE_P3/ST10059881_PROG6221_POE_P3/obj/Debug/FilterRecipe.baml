   M S B A M L   `   `   `  ����U  QST10059881_PROG6221_POE_P3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:ST10059881_PROG6221_POE_P3ST10059881_PROG6221_POE_P3  5   	   -    'ST10059881_PROG6221_POE_P3.FilterRecipe   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   :local(clr-namespace:ST10059881_PROG6221_POE_P3     5   	     � Title$  FilterRecipe��5   	   $	��450��6   $	��800��6+   ��5	      �� 5
   
    �� ImageSource$ Resources/chicken.jpeg��6   .��5      �  � ColumnDefinitions 5   
   �� 5      $��20 �6   �� 5      $��* �6   �� 5      $��20 �6    � RowDefinitions 5   
   �� 5      $��20 �6   �� 5      $��90 �6   �� 5      $	��200 �6   �� 5      $��40 �6   �� 5      $��20 �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ grdList��5      $��1��6$   $��2��64      AutoGenerateColumns . 6A   �� 5   
   -   5         ��Name$ 	btnFilter��5      $��1��6$   $��Filter��64   $
��Left=�6E   $��	288,0,0,0q�6`   $��1��6s   $��Center=�6�   $��70��6�   
�������6�   �� 5   
   -   5         ��Name$ 	lblFilter��5      $��1��6#   $��Filter Recipe: ��63   $
��Left=�6M   $��	31,13,0,0q�6h   $��1��6{   $	��Top=�6�   $��30(�6�   
���`���
���E��$��4q�6�   �� 5   
   -   5         ��Name$ 	txtFilter��5      $��1��6%   $
��Left=�65   $��	380,0,0,0q�6P   $��1��6c   	 �� TextWrapping$
	 Wrap=�6p   $�� ��6�   $	��120��6�   $��18��6�   $��Center=�6�   �� 5   
   -   5        $ btnMainMenu��5      $��1��6&   $��	Main Menu��66   $��Center=�6J   $��0,5,0,0q�6g   $��3��6x   $	��Top=�6�   $	��150��6�   
���  ��$��20(�6�   6�   5      5      