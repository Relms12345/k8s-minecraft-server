using System;
using System.IO;
using System.Net;

namespace Server
{
	internal static class Program
	{
		public static void Main()
		{
			#region FUN SHIT MAN
			var serverProperties = new[] {$"allow-flight={GetEnvVar(EnvironmentVars.ALLOW_FLIGHT)}",
				$"allow-nether={GetEnvVar(EnvironmentVars.ALLOW_NETHER)}",
				$"broadcast-console-to-ops={GetEnvVar(EnvironmentVars.BROADCAST_CONSOLE_TO_OPS)}",
				$"broadcast-rcon-to-ops={GetEnvVar(EnvironmentVars.BROADCAST_RCON_TO_OPS)}",
				$"difficulty={GetEnvVar(EnvironmentVars.DIFFICULTY)}",
				$"enable-command-block={GetEnvVar(EnvironmentVars.ENABLE_COMMAND_BLOCK)}",
				$"enable-jmx-monitoring={GetEnvVar(EnvironmentVars.ENABLE_JMX_MONITORING)}",
				$"enable-rcon={GetEnvVar(EnvironmentVars.ENABLE_RCON)}",
				$"sync-chunk-writes={GetEnvVar(EnvironmentVars.SYNC_CHUNK_WRITES)}",
				$"enable-status={GetEnvVar(EnvironmentVars.ENABLE_STATUS)}",
				$"enable-query={GetEnvVar(EnvironmentVars.ENABLE_QUERY)}",
				$"entity-broadcast-range-percentage={GetEnvVar(EnvironmentVars.ENTITY_BROADCAST_RANGE_PERCENTAGE)}",
				$"force-gamemode={GetEnvVar(EnvironmentVars.FORCE_GAMEMODE)}",
				$"function-permission-level={GetEnvVar(EnvironmentVars.FUNCTION_PERMISSION_LEVEL)}",
				$"gamemode={GetEnvVar(EnvironmentVars.GAMEMODE)}",
				$"generate-structures={GetEnvVar(EnvironmentVars.GENERATE_STRUCTURES)}",
				$"generator-settings={GetEnvVar(EnvironmentVars.GENERATOR_SETTINGS)}",
				$"hardcore={GetEnvVar(EnvironmentVars.HARDCORE)}",
				$"level-name={GetEnvVar(EnvironmentVars.LEVEL_NAME)}",
				$"level-seed={GetEnvVar(EnvironmentVars.LEVEL_SEED)}",
				$"level-type={GetEnvVar(EnvironmentVars.LEVEL_TYPE)}",
				$"max-build-height={GetEnvVar(EnvironmentVars.MAX_BUILD_HEIGHT)}",
				$"max-players={GetEnvVar(EnvironmentVars.MAX_PLAYERS)}",
				$"max-tick-time={GetEnvVar(EnvironmentVars.MAX_TICK_TIME)}",
				$"max-world-size={GetEnvVar(EnvironmentVars.MAX_WORLD_SIZE)}",
				$"motd={GetEnvVar(EnvironmentVars.MOTD)}",
				$"network-compression-threshold={GetEnvVar(EnvironmentVars.NETWORK_COMPRESSION_THRESHOLD)}",
				$"online-mode={GetEnvVar(EnvironmentVars.ONLINE_MODE)}",
				$"op-permission-level={GetEnvVar(EnvironmentVars.OP_PERMISSION_LEVEL)}",
				$"player-idle-timeout={GetEnvVar(EnvironmentVars.PLAYER_IDLE_TIMEOUT)}",
				$"prevent-proxy-connections={GetEnvVar(EnvironmentVars.PREVENT_PROXY_CONNECTION)}",
				$"pvp={GetEnvVar(EnvironmentVars.PVP)}",
				$"query.port={GetEnvVar(EnvironmentVars.QUERY_PORT)}",
				$"rate-limit={GetEnvVar(EnvironmentVars.RATE_LIMIT)}",
				$"rcon.password={GetEnvVar(EnvironmentVars.RCON_PASSWORD)}",
				$"rcon.port={GetEnvVar(EnvironmentVars.RCON_PORT)}",
				$"resource-pack={GetEnvVar(EnvironmentVars.RESOURCE_PACK)}",
				$"resource-pack-sha1={GetEnvVar(EnvironmentVars.RESOURCE_PACK_SHA1)}",
				$"server-ip={GetEnvVar(EnvironmentVars.SERVER_IP)}",
				$"server-port={GetEnvVar(EnvironmentVars.SERVER_PORT)}",
				$"snooper-enabled={GetEnvVar(EnvironmentVars.SNOOPER_ENABLED)}",
				$"spawn-animals={GetEnvVar(EnvironmentVars.SPAWN_ANIMALS)}",
				$"spawn-monsters={GetEnvVar(EnvironmentVars.SPAWN_MONSTERS)}",
				$"spawn-npcs={GetEnvVar(EnvironmentVars.SPAWN_NPCS)}",
				$"spawn-protection={GetEnvVar(EnvironmentVars.SPAWN_PROTECTION)}",
				$"use-native-transport={GetEnvVar(EnvironmentVars.USE_NATIVE_TRANSPORT)}",
				$"view-distance={GetEnvVar(EnvironmentVars.VIEW_DISTANCE)}",
				$"white-list={GetEnvVar(EnvironmentVars.WHITE_LIST)}",
				$"enforce-whitelist={GetEnvVar(EnvironmentVars.ENFORCE_WHITELIST)}"};
			#endregion
			
			File.WriteAllLines(Directory.GetCurrentDirectory() + "/server.properties", serverProperties);
		}

		private static string GetEnvVar(EnvironmentVars var)
		{
			return Environment.GetEnvironmentVariable(var.ToString()) != null ? 
				Environment.GetEnvironmentVariable(var.ToString()) :
				new DefaultEnvVars().GetType().GetProperty(var.ToString())?.GetValue(null)?.ToString();
		}
	}
}