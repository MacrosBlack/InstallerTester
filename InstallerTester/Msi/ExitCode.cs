namespace InstallerTester.Msi
{
    /// <summary>
    /// https://docs.microsoft.com/en-us/windows/desktop/msi/error-codes
    /// </summary>
    public enum ExitCode
    {
        /// <summary>
        /// Success.
        /// </summary>
        Success = 0,

        /// <summary>The data is invalid.</summary>
        INVALID_DATA = 13,

        ///	<summary>
        ///	One of the parameters was invalid.
        ///	</summary>
        INVALID_PARAMETER = 87,

        /// <summary>
        /// This value is returned when a custom action attempts to call a function that cannot be called from custom actions.The function returns the value CALL_NOT_IMPLEMENTED. Available beginning with Windows Installer version 3.0.
        /// </summary>
        CALL_NOT_IMPLEMENTED = 120,

        ///	<summary>
        ///	If Windows Installer determines a product may be incompatible with the current operating system, it displays a dialog box informing the user and asking whether to try to install anyway.This error code is returned if the user chooses not to try the installation.
        ///	</summary>
        APPHELP_BLOCK = 1259,

        /// <summary>
        /// The Windows Installer service could not be accessed.Contact your support personnel to verify that the Windows Installer service is properly registered.
        /// </summary>
        INSTALL_SERVICE_FAILURE = 1601,

        // The user cancels installation.
        INSTALL_USEREXIT = 1602,

        /// <summary>
        /// A fatal error occurred during installation.
        /// </summary>
        INSTALL_FAILURE = 1603,

        /// <summary>
        /// Installation suspended, incomplete.
        /// </summary>
        INSTALL_SUSPEND = 1604,

        /// <summary>
        /// This action is only valid for products that are currently installed.
        /// </summary>
        UNKNOWN_PRODUCT = 1605,

        /// <summary>
        /// The feature identifier is not registered.
        /// </summary>
        UNKNOWN_FEATURE = 1606,

        /// <summary>
        /// The component identifier is not registered.
        /// </summary>
        UNKNOWN_COMPONENT = 1607,

        /// <summary>
        /// This is an unknown property.
        /// </summary>
        UNKNOWN_PROPERTY = 1608,

        /// <summary>
        /// The handle is in an invalid state.
        /// </summary>
        INVALID_HANDLE_STATE = 1609,

        /// <summary>
        /// The configuration data for this product is corrupt.Contact your support personnel.
        /// </summary>
        BAD_CONFIGURATION = 1610,

        /// <summary>
        ///  The component qualifier not present.
        /// </summary>
        INDEX_ABSENT = 1611,

        /// <summary>
        ///  The installation source for this product is not available. Verify that the source exists and that you can access it.
        /// </summary>
        INSTALL_SOURCE_ABSENT = 1612,

        /// <summary>
        ///  This installation package cannot be installed by the Windows Installer service.You must install a Windows service pack that contains a newer version of the Windows Installer service.
        /// </summary>
        INSTALL_PACKAGE_VERSION = 1613,

        /// <summary>
        ///  The product is uninstalled.
        /// </summary>
        PRODUCT_UNINSTALLED = 1614,

        /// <summary>
        ///  The SQL query syntax is invalid or unsupported.
        /// </summary>
        BAD_QUERY_SYNTAX = 1615,

        /// <summary>
        ///  The record field does not exist.
        /// </summary>
        INVALID_FIELD = 1616,

        /// <summary>
        ///  Another installation is already in progress.Complete that installation before proceeding with this install.For information about the mutex, see _MSIExecute Mutex.
        /// </summary>
        INSTALL_ALREADY_RUNNING = 1618,

        /// <summary>
        ///  This installation package could not be opened.Verify that the package exists and is accessible, or contact the application vendor to verify that this is a valid Windows Installer package.
        /// </summary>
        INSTALL_PACKAGE_OPEN_FAILED = 1619,

        /// <summary>
        ///  This installation package could not be opened.Contact the application vendor to verify that this is a valid Windows Installer package.
        /// </summary>
        INSTALL_PACKAGE_INVALID = 1620,

        /// <summary>
        ///  There was an error starting the Windows Installer service user interface. Contact your support personnel.
        /// </summary>
        INSTALL_UI_FAILURE = 1621,

        /// <summary>
        ///  There was an error opening installation log file. Verify that the specified log file location exists and is writable.
        /// </summary>
        INSTALL_LOG_FAILURE = 1622,

        /// <summary>
        ///  This language of this installation package is not supported by your system.
        /// </summary>
        INSTALL_LANGUAGE_UNSUPPORTED = 1623,

        /// <summary>
        ///  There was an error applying transforms. Verify that the specified transform paths are valid.
        /// </summary>
        INSTALL_TRANSFORM_FAILURE = 1624,

        /// <summary>
        ///  This installation is forbidden by system policy. Contact your system administrator.
        /// </summary>
        INSTALL_PACKAGE_REJECTED = 1625,

        /// <summary>
        ///  The function could not be executed.
        /// </summary>
        FUNCTION_NOT_CALLED = 1626,

        /// <summary>
        ///  The function failed during execution.
        /// </summary>
        FUNCTION_FAILED = 1627,

        /// <summary>
        ///  An invalid or unknown table was specified.
        /// </summary>
        INVALID_TABLE = 1628,

        /// <summary>
        ///  The data supplied is the wrong type.
        /// </summary>
        DATATYPE_MISMATCH = 1629,

        /// <summary>
        ///  Data of this type is not supported.
        /// </summary>
        UNSUPPORTED_TYPE = 1630,

        /// <summary>
        /// The Windows Installer service failed to start.Contact your support personnel.
        /// </summary>
        CREATE_FAILED = 1631,

        /// <summary>
        ///  The Temp folder is either full or inaccessible. Verify that the Temp folder exists and that you can write to it.
        /// </summary>
        INSTALL_TEMP_UNWRITABLE = 1632,

        /// <summary>
        /// This installation package is not supported on this platform.Contact your application vendor.
        /// </summary>
        INSTALL_PLATFORM_UNSUPPORTED = 1633,

        /// <summary>
        ///  Component is not used on this machine.
        /// </summary>
        INSTALL_NOTUSED = 1634,

        /// <summary>
        ///  This patch package could not be opened.Verify that the patch package exists and is accessible, or contact the application vendor to verify that this is a valid Windows Installer patch package.
        /// </summary>
        PATCH_PACKAGE_OPEN_FAILED = 1635,

        /// <summary>
        ///  This patch package could not be opened.Contact the application vendor to verify that this is a valid Windows Installer patch package.
        /// </summary>
        PATCH_PACKAGE_INVALID = 1636,

        /// <summary>
        ///  This patch package cannot be processed by the Windows Installer service.You must install a Windows service pack that contains a newer version of the Windows Installer service.
        /// </summary>
        PATCH_PACKAGE_UNSUPPORTED = 1637,

        /// <summary>
        ///  Another version of this product is already installed. Installation of this version cannot continue. To configure or remove the existing version of this product, use Add/Remove Programs in Control Panel.
        /// </summary>
        PRODUCT_VERSION = 1638,

        /// <summary>
        ///  Invalid command line argument. Consult the Windows Installer SDK for detailed command-line help.
        /// </summary>
        INVALID_COMMAND_LINE = 1639,

        /// <summary>
        ///  The current user is not permitted to perform installations from a client session of a server running the Terminal Server role service.
        /// </summary>
        INSTALL_REMOTE_DISALLOWED = 1640,

        /// <summary>
        /// The installer has initiated a restart. This message is indicative of a success.
        /// </summary>
        SUCCESS_REBOOT_INITIATED = 1641,

        /// <summary>
        ///  The installer cannot install the upgrade patch because the program being upgraded may be missing or the upgrade patch updates a different version of the program. Verify that the program to be upgraded exists on your computer and that you have the correct upgrade patch.
        /// </summary>
        PATCH_TARGET_NOT_FOUND = 1642,

        /// <summary>
        ///  The patch package is not permitted by system policy.
        /// </summary>
        PATCH_PACKAGE_REJECTED = 1643,

        /// <summary>
        ///  One or more customizations are not permitted by system policy.
        /// </summary>
        INSTALL_TRANSFORM_REJECTED = 1644,

        /// <summary>
        /// Windows Installer does not permit installation from a Remote Desktop Connection.
        /// </summary>
        INSTALL_REMOTE_PROHIBITED = 1645,

        /// <summary>
        ///  //	The patch package is not a removable patch package.Available beginning with Windows Installer version 3.0.
        /// </summary>
        PATCH_REMOVAL_UNSUPPORTED = 1646,

        /// <summary>
        ///  The patch is not applied to this product. Available beginning with Windows Installer version 3.0.
        /// </summary>
        UNKNOWN_PATCH = 1647,

        /// <summary>
        ///  No valid sequence could be found for the set of patches. Available beginning with Windows Installer version 3.0.
        /// </summary>
        PATCH_NO_SEQUENCE = 1648,

        /// <summary>
        ///  //	Patch removal was disallowed by policy. Available beginning with Windows Installer version 3.0.
        /// </summary>
        PATCH_REMOVAL_DISALLOWED = 1649,

        /// <summary>
        ///  The XML patch data is invalid.Available beginning with Windows Installer version 3.0.
        /// </summary>
        INVALID_PATCH_XML = 1650,

        /// <summary>
        /// //	Administrative user failed to apply patch for a per-user managed or a per-machine application that is in advertise state. Available beginning with Windows Installer version 3.0.
        /// </summary>
        PATCH_MANAGED_ADVERTISED_PRODUCT = 1651, 

        ///	<summary>Windows Installer is not accessible when the computer is in Safe Mode. Exit Safe Mode and try again or try using System Restore to return your computer to a previous state.Available beginning with Windows Installer version 3.0</summary>
        INSTALL_SERVICE_SAFEBOOT = 1652,

        /// <summary>
        /// Could not perform a multiple-package transaction because rollback has been disabled.Multiple-Package Installations cannot run if rollback is disabled.Available beginning with Windows Installer version 3.0.
        /// </summary>
        ROLLBACK_DISABLED = 1653,

        ///	<summary>
        ///	The app that you are trying to run is not supported on this version of Windows.A Windows Installer package, patch, or transform that has not been signed by Microsoft cannot be installed on an ARM computer.
        ///	</summary>
        INSTALL_REJECTED = 1654,

        /// <summary>
        /// A restart is required to complete the install.This message is indicative of a success. This does not include installs where the ForceReboot action is run.
        /// </summary>
        SUCCESS_REBOOT_REQUIRED = 3010,
    }

    public static class ExitCodeHelper
    {
        public static bool IsSuccess(ExitCode exitCode)
        {
            return true ? 
                exitCode == ExitCode.Success || 
                exitCode == ExitCode.SUCCESS_REBOOT_INITIATED || 
                exitCode == ExitCode.SUCCESS_REBOOT_REQUIRED 
                : false;
        }
    }
}
