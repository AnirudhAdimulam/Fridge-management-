   M S B A M L   `   `   `  ����L  HFridge Management, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:Fridge_ManagementFridge_Management  5   	   $    Fridge_Management.shoppinglist   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:Fridge_Management     5   	   -   5           sty_win#��[  5
   	     � WindowStartupLocation$  CenterOwner=�6*   .��5      �  � RowDefinitions 5   
   �� 5      $	��45* �6   �� 5      $
��361* �6   �� 5      $	��13* �6    � ColumnDefinitions 5   
   �� 5      $��10 �6   �� 5      $
��134* �6   �� 5      $��5 �6   �� 5      $
��233* �6   �� 5      $��5 �6   �� 5      $
��146* �6   �� 5      $��9* �6   .+�5   
   �� $��Suggested products��6   $��13(�6-   $
��Left=�6;   $��1��6^   $
��Left=�6n   $��0,10,0,0q�6�   $	��Top=�6�   $��Bottom=�6�   $��35��6�   $	��134��6�   �� 5   
    �� Orientation$ Vertical=�6   $	��Top=�6,   $��1��6D   $��1��6Q   $	��336��6a   .+�5      �� $ Vertical=�6   $	��Top=�60   $��1��6H   $��1��6U   $	��0,4q�6e   .+�5      �� $
��Left=�6   $
��Wrap=�67     sty_cap#��[ 6K   $��Enter a product name��6l   $��2q�6�   $	��Top=�6�   �� 5       -   5        $��tbx_flitter��5       $��1��6-   $
��Left=�6=    �� TextWrapping$
 Wrap=�6Y   $	��Top=�6�   $��1��6�   $	��130��6�   $��0,0,0,2q�6�    � ToolTip$ enter the text to filter��6�   5"      �� 5$      -   5         ��Name$ Lbx_suggestions��5$      $��1��6/   $��Stretch=�6?   $��2��6]   $��0,0,1,0q�6j   $��2��6{   $	��260��6�   ��5%      �� 5&      .R�5'      �� �� 5(      �6   �� *name+5*      5+      5-      52      �� 53   
   $��Manage shopping list��6   $��13(�60   $
��Left=�6>   $��5��6a   $
��Left=�6q   $��Bottom=�6�   $��Bottom=�6�   $��35��6�   $	��146��6�   �� 55   
   $ Vertical=�6   $	��Top=�6,   $��1��6D   $��5��6Q   $	��364��6a   $��0,0,7,0q�6n   $��2��6   .+�56      �� $ Vertical=�6   $	��Top=�6z   $��1��6�   $��5��6�   $	��3,4q�6�    � DataContext 60   ��  �� ElementName$ Lbx_shopping_list��	 �� Path$	 SelectedItem�.+�57      �� $
��Left=�6   $
��Wrap=�67   #��[ 6K   $��Product name :��6l   $	��Top=�6�   �� 58      -   5        $��
Tbx_filter��58      $	��Top=�6I   $4 .enter the product name to add to shopping list��6a   ��6,   �� *productname+6a   59      �� 5;      -   5        $ Lbx_shopping_list��5;      $��0��61   $��Stretch=�6B   $��2��6b   $��2��6o   $	��261��6�   $	��130��6�   ��5<      �� 5=      .R�5>      �� $��0,0,0,4q�6$   �� 5?      $
��Bold"�6;   �6   �� *productname+6;    �� 5@      $� ��6   �� 6(   5A      5B      5D      �� 5F      $��Center=�6   $ 
Horizontal=�66   $��1��6O   $��5��6\   $��40��6l   $��Bottom=�6x   $	��0,5q�6�   .+�5G      �� -   5        
 ��Name$
 Btn_Add��5G      $	��Add��6*   
����� �$��50��6Q   $��2q�6\   $/ )click here to add new product to the list��6}   �� 5H      -   5        $
 
Btn_delete��5H      
���  ��$��Delete��6>   $��50��6O   $��2q�6Z   $9 3click here to remove selected product from the list��6   5J      5M      �� 5N   
   $��3��6   $
��Left=�6%   $��	10,10,0,0q�6@   $��1��6S   $
��Wrap=�6`   $��Product description��6t   $��15(�6�   $	��Top=�6�   $��23��6�   $	��142��6�   �� 5P   
   $��3��6   $ Vertical=�6l   $��1��6�   $��Center=�6�   $	��223��6�   $	��Top=�6�   $	��316��6�   $��	10,35,0,0q�6�    6%   �� $ Lbx_suggestions��$	 SelectedItem�.+�5R      �� -   5        $��tbx_sugg��5R      $��20(�6(   
����  �$��5,5,0,10q�6H   ��6Z   �� *name+�� 5U      $��96��61   $	��100��6=   $��	62,0,61,0q�6I   ��6   �� *	imagePath+6I   �� 5V      $
��Wrap=�6   $��Benifits��6,   $
��Bold"�6<   $	��2,0q�6N   $��14(�6[   �� 5W      $
��Wrap=�6   $��12(�6G   $	��108��6U   $	��5,0q�6b   ��6,   �� *
benifits+6b   �� 5X      -	   5        $��btn_Add_to_lst��5X      
����� �$��Add to shopping list��6D   $��20,10q�6c   $��34��6�   $> 8click here to add suggested product to the shopping list��6�   5\      5`      5a      