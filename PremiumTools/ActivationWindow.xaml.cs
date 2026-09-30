<Window x:Class="PremiumTools.ActivationWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        Title="Activation"
        Width="520"
        Height="350"
        WindowStartupLocation="CenterScreen"
        ResizeMode="NoResize"
        Background="#040b14"
        WindowStyle="SingleBorderWindow" >
    <Grid>
        <Grid.RowDefinitions>
            <RowDefinition Height="Auto"/>
            <RowDefinition Height="*"/>
            <RowDefinition Height="Auto"/>
        </Grid.RowDefinitions>

        <Border Grid.Row="0" Padding="22,18,22,8" BorderBrush="#1b2d48" BorderThickness="0,0,0,1">
            <StackPanel Orientation="Horizontal">
                <Border Width="42" Height="42" CornerRadius="10" Background="#0b1b34" BorderBrush="#1ee9ff" BorderThickness="2">
                    <TextBlock Text="⚡" Foreground="#1ee9ff" FontSize="20" HorizontalAlignment="Center" VerticalAlignment="Center"/>
                </Border>
                <StackPanel Margin="12,0,0,0" VerticalAlignment="Center">
                    <TextBlock Text="PREMIUM TOOLS" Foreground="#e7f7ff" FontSize="24" FontWeight="Bold"/>
                    <TextBlock Text="Version v1.0" Foreground="#5cb7d4" FontSize="10" Margin="0,2,0,0"/>
                </StackPanel>
            </StackPanel>
        </Border>

        <Border Grid.Row="1" Padding="26,18,26,10">
            <StackPanel VerticalAlignment="Center" HorizontalAlignment="Center" Width="380">
                <TextBlock Text="Enter activation key" Foreground="#edf7ff" FontSize="20" FontWeight="Bold" HorizontalAlignment="Center"/>
                <TextBlock Text="Use the key below to unlock the gaming optimizer dashboard." Foreground="#8ea0b0" FontSize="12" Margin="0,8,0,16" TextAlignment="Center" TextWrapping="Wrap"/>

                <Border Background="#0d1727" BorderBrush="#1b2d48" BorderThickness="1" CornerRadius="10" Padding="12,10,12,10">
                    <PasswordBox x:Name="KeyBox" Height="38" FontSize="18" Background="#0b1320" Foreground="#edf7ff" BorderThickness="0" VerticalContentAlignment="Center"/> 
                </Border>

                <TextBlock Text="Key: godego" Foreground="#63e0ff" FontSize="12" FontWeight="Bold" HorizontalAlignment="Center" Margin="0,15,0,0"/>
            </StackPanel>
        </Border>

        <Border Grid.Row="2" Padding="20,10,20,18" BorderBrush="#1b2d48" BorderThickness="0,1,0,0">
            <StackPanel Orientation="Horizontal" HorizontalAlignment="Right">
                <Button Width="130" Height="36" Content="Cancel" Margin="0,0,10,0"
                        Background="#101d2a" Foreground="#edf7ff" BorderBrush="#1b2d48" BorderThickness="1"
                        Click="CancelButton_Click"/>
                <Button Width="130" Height="36" Content="Unlock" 
                        Background="#0a2133" Foreground="#76e7ff" BorderBrush="#1ee9ff" BorderThickness="1"
                        Click="UnlockButton_Click"/>
            </StackPanel>
        </Border>
    </Grid>
</Window>
