   M S B A M L   `   `   `  ����F  BSaloonSharm, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:SaloonSharm.PagesSaloonSharm.Pages  5      #    SaloonSharm.Pages.RecordsPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:SaloonSharm.Pages     5        N� Title$  RecordsPage��5	      .��5      �  � RowDefinitions 5   
   �� 5      �� 5      $��0.15* �6    � ColumnDefinitions 5   
   �� 5      �� 5      .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ 	dgRecords��5         AutoGenerateColumns .  $��0��6C   $��0��6P   $��2��6`      Columns 5      4  .System.Windows.Controls.DataGridTemplateColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Дата��6)      CellTemplate 5      �� 5      .R�5      (  "System.Windows.Controls.DatePicker     SelectedDate 6)   �� 	 �� Path$	 
Order.Date�5      5      0  *System.Windows.Controls.DataGridTextColumn  5      $ Фамилия��6%   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 66   �� *Order.Client.LastName+  5      $ Имя��6%   
 62   �� *Order.Client.FirstName+  5      $ Отчество��6%   
 67   �� *Order.Client.MiddleName+  5       $ Услуги��6%   
 65   �� *Service.Name+5"      �� 5#   
   -   5         ��Name$ btnBack��5#   >   $��1��6   $��0��6   $��
Назад��6.   $��5q�6e   $	��200��6p   $
��Left=�6   5$      5%      