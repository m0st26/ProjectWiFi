   M S B A M L   `   `   `  ����Q  MParkWifi.DesktopClient, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:ParkWifi.DesktopClientParkWifi.DesktopClient  5   	   '    !ParkWifi.DesktopClient.MainWindow   5   	   e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:ParkWifi.DesktopClient     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � 	Resources 5	         Montserrat-Medium��%S   &	        *�5
   
   1-pack://application:,,,/Fonts/#Med Uch Regular)�5      5      .��5      � #��[  6   $��14(�6E    � ColumnDefinitions 5   
   �� 5      $
��0.5* �6   �� 5      $��* �6   .+�5   
   �� $��0��6   $��5q�6"   
���   �
���������6T   �� *	ParkWifis+ �� SelectedItem 6v   �� *CurrentParkWifi+��5      �� 5      .R�5      �� $��5q�6!   .+�5      �� $��14(�6$   ��62   ��  �� Path$
 Name�5      5      5      �� 5   
   $��1��6   $��0,0,0,0q�6M    � DataContext 6%   �� *CurrentParkWifi+.+�5      ��  �� Padding$ 3q�6   $��	ExtraBold"�6$   $+��%Информация о WiFi сети��6;   $��Center=�6Y   �� 5       $ 2q�6   $
��Wrap=�6$   ��68   ��  �� StringFormat$ 	Name: {0}��$
 Name��� 5!      $ 2q�6   $
��Wrap=�6$   ��68   �� $ Status: {0}��$ status��� 5"      $ 2q�6   $
��Wrap=�6$   ��68   �� $ ParkName: {0}��$ ParkName��� 5#      $ 2q�6   $
��Wrap=�6$   ��68   �� $ wifiName: {0}��$ wifiName�5$      5%      5&      