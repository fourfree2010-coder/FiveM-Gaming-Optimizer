<Window x:Class="PremiumTools.MainWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        Title="Premium Tools v1.0"
        Width="1600"
        Height="930"
        WindowStartupLocation="CenterScreen"
        ResizeMode="CanMinimize"
        Background="#040b14"
        Foreground="#eaf6ff">
    <Window.Resources>
        <Style x:Key="CyberButton" TargetType="Button">
            <Setter Property="Background" Value="#0a2133"/>
            <Setter Property="Foreground" Value="#76e7ff"/>
            <Setter Property="BorderBrush" Value="#1ee9ff"/>
            <Setter Property="BorderThickness" Value="1"/>
            <Setter Property="Cursor" Value="Hand"/>
            <Setter Property="Template">
                <Setter.Value>
                    <ControlTemplate TargetType="Button">
                        <Border Background="{TemplateBinding Background}" BorderBrush="{TemplateBinding BorderBrush}" BorderThickness="{TemplateBinding BorderThickness}" CornerRadius="8">
                            <ContentPresenter HorizontalAlignment="Center" VerticalAlignment="Center"/>
                        </Border>
                    </ControlTemplate>
                </Setter.Value>
            </Setter>
        </Style>
    </Window.Resources>

    <Grid>
        <Grid.ColumnDefinitions>
            <ColumnDefinition Width="280"/>
            <ColumnDefinition Width="*"/>
        </Grid.ColumnDefinitions>

        <Border Grid.Column="0" Background="#050d1b" BorderBrush="#19273f" BorderThickness="0,0,1,0">
            <Grid>
                <Grid.RowDefinitions>
                    <RowDefinition Height="90"/>
                    <RowDefinition Height="180"/>
                    <RowDefinition Height="*"/>
                    <RowDefinition Height="140"/>
                </Grid.RowDefinitions>

                <Border Grid.Row="0" Padding="18,18,18,8" BorderBrush="#19273f" BorderThickness="0,0,0,1">
                    <StackPanel Orientation="Horizontal" VerticalAlignment="Center">
                        <Border Width="36" Height="36" CornerRadius="10" Background="#0b1b34" BorderBrush="#1ee9ff" BorderThickness="2">
                            <TextBlock Text="⚡" Foreground="#1ee9ff" FontSize="18" HorizontalAlignment="Center" VerticalAlignment="Center" FontWeight="Bold"/>
                        </Border>
                        <StackPanel Margin="12,0,0,0" VerticalAlignment="Center">
                            <TextBlock Text="PREMIUM TOOLS" Foreground="#e7f7ff" FontSize="16" FontWeight="Bold"/>
                            <TextBlock Text="VERSION v1.0" Foreground="#5cb7d4" FontSize="9" Margin="0,2,0,0"/>
                        </StackPanel>
                    </StackPanel>
                </Border>

                <Border Grid.Row="1" Margin="16,14,16,10" Background="#0d1626" BorderBrush="#1e3556" BorderThickness="1" CornerRadius="12" Padding="12,10,12,10">
                    <StackPanel Orientation="Horizontal">
                        <Border Width="36" Height="36" CornerRadius="18" Background="#08272f" BorderBrush="#1ee9ff" BorderThickness="1.5" VerticalAlignment="Center">
                            <TextBlock Text="👤" FontSize="16" HorizontalAlignment="Center" VerticalAlignment="Center"/>
                        </Border>
                        <StackPanel Margin="10,0,0,0" VerticalAlignment="Center">
                            <TextBlock Text="Dev" Foreground="#eaf6ff" FontSize="15" FontWeight="Bold"/>
                            <TextBlock Text="Active" Foreground="#44e7b5" FontSize="11" Margin="0,2,0,0"/>
                        </StackPanel>
                    </StackPanel>
                </Border>

                <StackPanel Grid.Row="2" Margin="14,10,14,0" VerticalAlignment="Top">
                    <Button Height="44" Background="#0c1c30" BorderBrush="#17314e" BorderThickness="1" Foreground="#dfeaf8" FontWeight="Bold" FontSize="13" HorizontalContentAlignment="Left" Padding="12,0,0,0" Cursor="Hand" Click="DashboardButton_Click">
                        <StackPanel Orientation="Horizontal" VerticalAlignment="Center">
                            <TextBlock Text="⊙" FontSize="16" Foreground="#1ee9ff" Margin="0,0,10,0"/>
                            <TextBlock Text="1. DASHBOARD" VerticalAlignment="Center"/>
                        </StackPanel>
                    </Button>

                    <Button Height="44" Margin="0,6,0,0" Background="Transparent" BorderBrush="#1a2a3d" BorderThickness="1" Foreground="#dfeaf8" FontWeight="Bold" FontSize="13" HorizontalContentAlignment="Left" Padding="12,0,0,0" Cursor="Hand" Click="CleaningButton_Click">
                        <StackPanel Orientation="Horizontal" VerticalAlignment="Center">
                            <TextBlock Text="🧹" FontSize="16" Margin="0,0,10,0"/>
                            <TextBlock Text="2. CLEANING" VerticalAlignment="Center"/>
                        </StackPanel>
                    </Button>

                    <Button Height="44" Margin="0,6,0,0" Background="Transparent" BorderBrush="#1a2a3d" BorderThickness="1" Foreground="#dfeaf8" FontWeight="Bold" FontSize="13" HorizontalContentAlignment="Left" Padding="12,0,0,0" Cursor="Hand" Click="OptimizeButton_Click">
                        <StackPanel Orientation="Horizontal" VerticalAlignment="Center">
                            <TextBlock Text="⚙" FontSize="16" Margin="0,0,10,0"/>
                            <TextBlock Text="3. OPTIMIZE" VerticalAlignment="Center"/>
                        </StackPanel>
                    </Button>

                    <Button Height="44" Margin="0,6,0,0" Background="Transparent" BorderBrush="#1a2a3d" BorderThickness="1" Foreground="#dfeaf8" FontWeight="Bold" FontSize="13" HorizontalContentAlignment="Left" Padding="12,0,0,0" Cursor="Hand" Click="BoostButton_Click">
                        <StackPanel Orientation="Horizontal" VerticalAlignment="Center">
                            <TextBlock Text="🎯" FontSize="16" Margin="0,0,10,0"/>
                            <TextBlock Text="4. FIVEM BOOSTER" VerticalAlignment="Center"/>
                        </StackPanel>
                    </Button>

                    <Button Height="44" Margin="0,6,0,0" Background="Transparent" BorderBrush="#1a2a3d" BorderThickness="1" Foreground="#dfeaf8" FontWeight="Bold" FontSize="13" HorizontalContentAlignment="Left" Padding="12,0,0,0" Cursor="Hand" Click="QuickToolsButton_Click">
                        <StackPanel Orientation="Horizontal" VerticalAlignment="Center">
                            <TextBlock Text="🔧" FontSize="16" Margin="0,0,10,0"/>
                            <TextBlock Text="5. QUICK TOOLS" VerticalAlignment="Center"/>
                        </StackPanel>
                    </Button>

                    <Button Height="44" Margin="0,6,0,0" Background="Transparent" BorderBrush="#1a2a3d" BorderThickness="1" Foreground="#dfeaf8" FontWeight="Bold" FontSize="13" HorizontalContentAlignment="Left" Padding="12,0,0,0" Cursor="Hand" Click="SystemInfoButton_Click">
                        <StackPanel Orientation="Horizontal" VerticalAlignment="Center">
                            <TextBlock Text="ℹ" FontSize="16" Margin="0,0,10,0"/>
                            <TextBlock Text="6. SYSTEM INFO" VerticalAlignment="Center"/>
                        </StackPanel>
                    </Button>

                    <Button Height="44" Margin="0,6,0,0" Background="Transparent" BorderBrush="#1a2a3d" BorderThickness="1" Foreground="#dfeaf8" FontWeight="Bold" FontSize="13" HorizontalContentAlignment="Left" Padding="12,0,0,0" Cursor="Hand" Click="SecurityButton_Click">
                        <StackPanel Orientation="Horizontal" VerticalAlignment="Center">
                            <TextBlock Text="🔐" FontSize="16" Margin="0,0,10,0"/>
                            <TextBlock Text="7. LICENSE &amp; SECURITY" VerticalAlignment="Center"/>
                        </StackPanel>
                    </Button>
                </StackPanel>

                <StackPanel Grid.Row="3" Margin="16,0,16,14" VerticalAlignment="Bottom">
                    <Separator Background="#203249" Margin="0,0,0,10"/>
                    <TextBlock Foreground="#7d8da2" FontSize="10" Text="OS: Kernel10.0 22H2"/>
                    <TextBlock Foreground="#7d8da2" FontSize="10" Text="Version: v1.0" Margin="0,4,0,0"/>
                    <TextBlock Foreground="#7d8da2" FontSize="9" Text="PREMIUM TOOLS v1.0 © 2026. All rights reserved." TextWrapping="Wrap" Margin="0,10,0,0"/>
                </StackPanel>
            </Grid>
        </Border>

        <Grid Grid.Column="1" Background="#040b14">
            <Grid.RowDefinitions>
                <RowDefinition Height="70"/>
                <RowDefinition Height="*"/>
            </Grid.RowDefinitions>

            <Border Grid.Row="0" BorderBrush="#19273d" BorderThickness="0,0,0,1" Background="#050d1b" Padding="22,0,22,0">
                <Grid>
                    <Grid.ColumnDefinitions>
                        <ColumnDefinition Width="Auto"/>
                        <ColumnDefinition Width="*"/>
                        <ColumnDefinition Width="Auto"/>
                    </Grid.ColumnDefinitions>

                    <StackPanel Grid.Column="0" Orientation="Horizontal" VerticalAlignment="Center" Margin="0,0,0,0">
                        <Button Width="100" Height="36" Background="#0a2133" Foreground="#76e7ff" BorderBrush="#1ee9ff" BorderThickness="1" Content="ADMINISTRATOR" FontWeight="Bold" FontSize="11" Cursor="Hand" Click="AdministratorButton_Click"/>
                        <Button Width="80" Height="36" Margin="10,0,0,0" Background="#0a2133" Foreground="#76e7ff" BorderBrush="#1ee9ff" BorderThickness="1" Content="HWID" FontWeight="Bold" FontSize="11" Cursor="Hand" Click="HwidButton_Click"/>
                        <Button Width="140" Height="36" Margin="10,0,0,0" Background="#0a2133" Foreground="#76e7ff" BorderBrush="#1ee9ff" BorderThickness="1" Content="GAMING PROFILE" FontWeight="Bold" FontSize="11" Cursor="Hand" Click="ProfileButton_Click"/>
                    </StackPanel>

                    <StackPanel Grid.Column="2" Orientation="Horizontal" VerticalAlignment="Center">
                        <Border Width="120" Height="34" Background="#0a2133" BorderBrush="#1ee9ff" BorderThickness="1" CornerRadius="6">
                            <TextBlock Text="🔑 KEY: godego" Foreground="#63e0ff" FontSize="11" FontWeight="Bold" VerticalAlignment="Center" HorizontalAlignment="Center"/>
                        </Border>
                        <Button Width="36" Height="36" Margin="8,0,0,0" Background="#0a233c" BorderBrush="#1b3358" BorderThickness="1" Foreground="#dfeaf8" FontWeight="Bold" Content="TH" Cursor="Hand" Click="LanguageButton_Click"/>
                        <Button Width="36" Height="36" Margin="8,0,0,0" Background="#0b1624" BorderBrush="#182d45" BorderThickness="1" Foreground="#dfeaf8" Content="⚙" Cursor="Hand" Click="SettingsButton_Click"/>
                        <Button Width="36" Height="36" Margin="8,0,0,0" Background="#0b1624" BorderBrush="#182d45" BorderThickness="1" Foreground="#dfeaf8" Content="−" Cursor="Hand" Click="MinimizeButton_Click"/>
                        <Button Width="36" Height="36" Margin="8,0,0,0" Background="#0b1624" BorderBrush="#182d45" BorderThickness="1" Foreground="#dfeaf8" Content="✕" Cursor="Hand" Click="CloseButton_Click"/>
                    </StackPanel>
                </Grid>
            </Border>

            <ScrollViewer Grid.Row="1" VerticalScrollBarVisibility="Auto" Background="#040b14">
                <StackPanel Margin="22,18,22,28">
                    <Border Background="#101d2a" BorderBrush="#1b2d48" BorderThickness="1" CornerRadius="12" Padding="20,18,20,18">
                        <StackPanel>
                            <StackPanel Orientation="Horizontal">
                                <TextBlock Text="◔" Foreground="#1ee9ff" FontSize="22" FontWeight="Bold"/>
                                <TextBlock Text="System Live Stats Realtime" Foreground="#edf7ff" FontSize="26" FontWeight="Bold" Margin="10,0,0,0"/>
                            </StackPanel>
                            <TextBlock Text="การทำงานของระบบเรียลไทม์ (Windows 11) พร้อมระบบปรับปรุงประมวลผล ลด Lag และ Ping" Foreground="#8ea0b0" FontSize="12" Margin="0,6,0,0" TextWrapping="Wrap"/>
                        </StackPanel>
                    </Border>

                    <Grid Margin="0,18,0,0">
                        <Grid.ColumnDefinitions>
                            <ColumnDefinition Width="*"/>
                            <ColumnDefinition Width="*"/>
                            <ColumnDefinition Width="*"/>
                        </Grid.ColumnDefinitions>

                        <Border Grid.Column="0" Margin="0,0,10,0" Background="#101d2a" BorderBrush="#1b2d48" BorderThickness="1" CornerRadius="12" Padding="16,14,16,16">
                            <StackPanel>
                                <StackPanel Orientation="Horizontal">
                                    <TextBlock Text="◴" Foreground="#1ee9ff" FontSize="18" FontWeight="Bold"/>
                                    <TextBlock Text="CPU USAGE" Foreground="#eaf6ff" FontWeight="Bold" FontSize="16" Margin="10,0,0,0"/>
                                </StackPanel>
                                <ProgressBar Name="ProgressCpu" Height="11" Minimum="0" Maximum="100" Value="27" Foreground="#1ee9ff" Background="#1d2d43" Margin="0,12,0,0"/>
                                <TextBlock Name="LabelCpu" Text="Processor Active Load" Foreground="#8ea0b0" FontSize="12" Margin="0,12,0,0"/>
                            </StackPanel>
                        </Border>

                        <Border Grid.Column="1" Margin="5,0,5,0" Background="#101d2a" BorderBrush="#1b2d48" BorderThickness="1" CornerRadius="12" Padding="16,14,16,16">
                            <StackPanel>
                                <StackPanel Orientation="Horizontal">
                                    <TextBlock Text="◫" Foreground="#ff5ac8" FontSize="18" FontWeight="Bold"/>
                                    <TextBlock Text="RAM USAGE" Foreground="#eaf6ff" FontWeight="Bold" FontSize="16" Margin="10,0,0,0"/>
                                </StackPanel>
                                <ProgressBar Name="ProgressRam" Height="11" Minimum="0" Maximum="100" Value="43" Foreground="#ff5ac8" Background="#1d2d43" Margin="0,12,0,0"/>
                                <TextBlock Name="LabelRam" Text="32.0 GB / 64.0 GB" Foreground="#8ea0b0" FontSize="12" Margin="0,12,0,0"/>
                            </StackPanel>
                        </Border>

                        <Border Grid.Column="2" Margin="10,0,0,0" Background="#101d2a" BorderBrush="#1b2d48" BorderThickness="1" CornerRadius="12" Padding="16,14,16,16">
                            <StackPanel>
                                <StackPanel Orientation="Horizontal">
                                    <TextBlock Text="◧" Foreground="#f5b729" FontSize="18" FontWeight="Bold"/>
                                    <TextBlock Text="GPU USAGE" Foreground="#eaf6ff" FontWeight="Bold" FontSize="16" Margin="10,0,0,0"/>
                                </StackPanel>
                                <ProgressBar Name="ProgressGpu" Height="11" Minimum="0" Maximum="100" Value="19" Foreground="#f5b729" Background="#1d2d43" Margin="0,12,0,0"/>
                                <TextBlock Name="LabelGpu" Text="NVIDIA / AMD Active Load" Foreground="#8ea0b0" FontSize="12" Margin="0,12,0,0"/>
                            </StackPanel>
                        </Border>
                    </Grid>

                    <Border Background="#101d2a" BorderBrush="#1b2d48" BorderThickness="1" CornerRadius="12" Padding="18,16,18,10" Margin="0,18,0,0">
                        <StackPanel>
                            <StackPanel Orientation="Horizontal">
                                <TextBlock Text="📈" Foreground="#1ee9ff" FontSize="20"/>
                                <TextBlock Text="Realtime System Performance Graph" Foreground="#edf7ff" FontSize="24" FontWeight="Bold" Margin="10,0,0,0"/>
                            </StackPanel>

                            <Canvas Height="180" Background="#06111d" Margin="0,12,0,0" ClipToBounds="True">
                                <Polyline Stroke="#1ee9ff" StrokeThickness="2" Points="0,140 60,130 120,120 180,160 240,110 300,70 360,90 420,120 480,100 540,80 600,90 660,100 720,120 780,90 840,110 900,150"/>
                                <Polyline Stroke="#ff5ac8" StrokeThickness="2" Points="0,130 60,125 120,115 180,140 240,120 300,100 360,80 420,90 480,115 540,130 600,110 660,140 720,95 780,120 840,100 900,130"/>
                                <Polyline Stroke="#f5b729" StrokeThickness="2" Points="0,175 60,150 120,160 180,170 240,140 300,115 360,130 420,110 480,100 540,90 600,120 660,100 720,110 780,190 840,150 900,140"/>
                            </Canvas>
                        </StackPanel>
                    </Border>

                    <TextBlock Text="Quick Access Shortcuts" Foreground="#edf7ff" FontSize="24" FontWeight="Bold" Margin="0,22,0,10"/>

                    <Grid>
                        <Grid.ColumnDefinitions>
                            <ColumnDefinition Width="*"/>
                            <ColumnDefinition Width="*"/>
                            <ColumnDefinition Width="*"/>
                            <ColumnDefinition Width="*"/>
                        </Grid.ColumnDefinitions>

                        <Button Grid.Column="0" Height="100" Margin="0,0,10,0" Background="#0d1727" BorderBrush="#1b2d48" BorderThickness="1" Cursor="Hand" Click="BoostButton_Click">
                            <StackPanel Orientation="Horizontal" Margin="12,0,0,0">
                                <Border Width="44" Height="44" CornerRadius="12" Background="#0b1d2d" BorderBrush="#1ee9ff" BorderThickness="1">
                                    <TextBlock Text="⚡" Foreground="#1ee9ff" FontSize="22" HorizontalAlignment="Center" VerticalAlignment="Center"/>
                                </Border>
                                <StackPanel Margin="12,0,0,0" VerticalAlignment="Center">
                                    <TextBlock Text="BOOST FIVEM" Foreground="#edf7ff" FontSize="14" FontWeight="Bold"/>
                                    <TextBlock Text="NOW" Foreground="#1ee9ff" FontSize="12" FontWeight="Bold" Margin="0,2,0,0"/>
                                </StackPanel>
                            </StackPanel>
                        </Button>

                        <Button Grid.Column="1" Height="100" Margin="5,0,5,0" Background="#0d1727" BorderBrush="#1b2d48" BorderThickness="1" Cursor="Hand" Click="CleaningButton_Click">
                            <StackPanel Orientation="Horizontal" Margin="12,0,0,0">
                                <Border Width="44" Height="44" CornerRadius="12" Background="#1b0f25" BorderBrush="#ff5ac8" BorderThickness="1">
                                    <TextBlock Text="🧹" Foreground="#ff5ac8" FontSize="22" HorizontalAlignment="Center" VerticalAlignment="Center"/>
                                </Border>
                                <StackPanel Margin="12,0,0,0" VerticalAlignment="Center">
                                    <TextBlock Text="Junk &amp; GPU" Foreground="#edf7ff" FontSize="14" FontWeight="Bold"/>
                                    <TextBlock Text="Cleaner" Foreground="#ff5ac8" FontSize="12" FontWeight="Bold"/>
                                </StackPanel>
                            </StackPanel>
                        </Button>

                        <Button Grid.Column="2" Height="100" Margin="5,0,5,0" Background="#0d1727" BorderBrush="#1b2d48" BorderThickness="1" Cursor="Hand" Click="StartupButton_Click">
                            <StackPanel Orientation="Horizontal" Margin="12,0,0,0">
                                <Border Width="44" Height="44" CornerRadius="12" Background="#0d1a28" BorderBrush="#67d9ff" BorderThickness="1">
                                    <TextBlock Text="⚙" Foreground="#67d9ff" FontSize="22" HorizontalAlignment="Center" VerticalAlignment="Center"/>
                                </Border>
                                <StackPanel Margin="12,0,0,0" VerticalAlignment="Center">
                                    <TextBlock Text="Startup" Foreground="#edf7ff" FontSize="14" FontWeight="Bold"/>
                                    <TextBlock Text="Manager" Foreground="#67d9ff" FontSize="12" FontWeight="Bold"/>
                                </StackPanel>
                            </StackPanel>
                        </Button>

                        <Button Grid.Column="3" Height="100" Margin="10,0,0,0" Background="#0d1727" BorderBrush="#1b2d48" BorderThickness="1" Cursor="Hand" Click="SystemInfoButton_Click">
                            <StackPanel Orientation="Horizontal" Margin="12,0,0,0">
                                <Border Width="44" Height="44" CornerRadius="12" Background="#1b1221" BorderBrush="#f5b729" BorderThickness="1">
                                    <TextBlock Text="ℹ" Foreground="#f5b729" FontSize="22" HorizontalAlignment="Center" VerticalAlignment="Center"/>
                                </Border>
                                <StackPanel Margin="12,0,0,0" VerticalAlignment="Center">
                                    <TextBlock Text="System Info" Foreground="#edf7ff" FontSize="14" FontWeight="Bold"/>
                                    <TextBlock Text="&amp; Copy Specs" Foreground="#f5b729" FontSize="12" FontWeight="Bold"/>
                                </StackPanel>
                            </StackPanel>
                        </Button>
                    </Grid>
                </StackPanel>
            </ScrollViewer>
        </Grid>
    </Grid>
</Window>
